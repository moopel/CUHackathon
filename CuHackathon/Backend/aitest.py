import pandas as pd
import tensorflow as tf
import numpy as np
from sklearn.preprocessing import StandardScaler, OneHotEncoder, LabelEncoder
from sklearn.metrics.pairwise import cosine_similarity
import random

def parse_data():
    data = pd.read_csv('assets/Superheroes.csv')

    # Ensure the columns contain only numeric data
    numerical_features = ['Combat', 'Durability', 'Intelligence', 'Power', 'Strength', 'Speed']
    for feature in numerical_features:
        data[feature] = pd.to_numeric(data[feature], errors='coerce')  # Convert columns to numeric, coercing errors to NaN

    # Handle missing values (e.g., fill with the mean of the column)
    data[numerical_features] = data[numerical_features].fillna(data[numerical_features].mean())  # Fill NaN values with the mean of each column

    scaler = StandardScaler()  # Initialize the StandardScaler
    data[numerical_features] = scaler.fit_transform(data[numerical_features])  # Scale the numerical features

    # Encode 'Alignment' and 'Creator' with LabelEncoder
    label_encoder = LabelEncoder()
    data['Alignment'] = label_encoder.fit_transform(data['Alignment'])  # Encode 'Alignment' with unique numerical values
    data['Creator'] = label_encoder.fit_transform(data['Creator'])  # Encode 'Creator' with unique numerical values

    # Encode 'Character' with OneHotEncoder
    categorical_features = ['Character']
    if 'Character' in data.columns:
        encoder = OneHotEncoder(sparse_output=False)
        encoded_features = encoder.fit_transform(data[categorical_features])

        # Convert encoded features to DataFrame
        encoded_df = pd.DataFrame(encoded_features, columns=encoder.get_feature_names_out(categorical_features))

        # Concatenate numerical, encoded categorical, and encoded 'Alignment' and 'Creator' features
        data = pd.concat([data, encoded_df], axis=1)
    else:
        print("Character column not found in data")

    return data

def initialize_ai():
    data = parse_data()
    
    # Check if 'Character' column exists before dropping
    if 'Character' in data.columns:
        data1 = data.drop(columns=['Character'])
    else:
        print("Character column not found in data")
        return

    # Define the model
    embedding_model = tf.keras.Sequential([
        tf.keras.layers.Dense(128, activation='relu'),
        tf.keras.layers.Dense(64, activation='relu'),
        tf.keras.layers.Dense(32)  # Embedding size
    ])

    # Separate heroes and villains
    heroes_data = data1[data1['Alignment'] == 3]
    villain_data = data1[data1['Alignment'] == 2]

    if heroes_data.empty or villain_data.empty:
        print("No heroes or villains found in the data")
        return

    # Convert to NumPy arrays (ensuring float32)
    heroes_array = heroes_data.drop(columns=['Alignment']).to_numpy(dtype=np.float32)
    villains_array = villain_data.drop(columns=['Alignment']).to_numpy(dtype=np.float32)

    # Compute embeddings
    embeddings_hero = tf.math.l2_normalize(embedding_model.predict(heroes_array), axis=1)
    embeddings_villain = tf.math.l2_normalize(embedding_model.predict(villains_array), axis=1)

    # Compute cosine similarity
    similarities = cosine_similarity(embeddings_hero, embeddings_villain)

    # Find top 3 heroes for each villain
    top_heroes_indices = np.argsort(-similarities, axis=0)[:3]

    # Ensure the index is within bounds
    if len(villain_data) > 10:
        villain_name = data.iloc[villain_data.index[10]]['Character']
    else:
        villain_name = data.iloc[villain_data.index[0]]['Character']

    # Get the top 3 heroes for the first villain
    top_heroes = [data.iloc[heroes_data.index[idx]]['Character'] for idx in top_heroes_indices[:, 0]]

    print(f"The best heroes to fight {villain_name} are {top_heroes}")

initialize_ai()
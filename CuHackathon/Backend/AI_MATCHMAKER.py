import pandas as pd
import tensorflow as tf
import numpy as np
from sklearn.preprocessing import StandardScaler, LabelEncoder
from sklearn.metrics.pairwise import cosine_similarity


def parse_data():
    data = pd.read_csv('assets/Superheroes.csv')

    # Ensure numerical data
    numerical_features = ['Combat', 'Durability', 'Intelligence', 'Power', 'Strength', 'Speed']
    for feature in numerical_features:
        data[feature] = pd.to_numeric(data[feature], errors='coerce')  # Convert to numeric

    # Handle missing values
    data[numerical_features] = data[numerical_features].fillna(data[numerical_features].mean())

    # Scale numerical features
    scaler = StandardScaler()
    data[numerical_features] = scaler.fit_transform(data[numerical_features])

    # Encode categorical features
    label_encoder = LabelEncoder()
    data['Alignment'] = label_encoder.fit_transform(data['Alignment'])  
    data['Creator'] = label_encoder.fit_transform(data['Creator'])

    categorical_features=['Alignment','Creator','Character']  

    # Drop unnecessary data
    data = data[data['Creator'] != 110] 

    features=numerical_features+categorical_features

    data=(data[features]) 

    return data


def initialize_ai():
    data = parse_data()
    
    # Drop non-numeric columns for model input
    data1 = data.drop(columns=['Character'])

    # Define Neural Network Model
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

    

    #Convert to NumPy arrays (ensuring float32)
    heroes_array = heroes_data.to_numpy(dtype=np.float32)
    villains_array = villain_data.to_numpy(dtype=np.float32)

    

    ##
    # Compute embeddings
    embeddings_hero = embedding_model.predict(heroes_array)
    embeddings_villain = embedding_model.predict(villains_array)

    # Compute cosine similarity
    similarities = cosine_similarity(embeddings_hero, embeddings_villain)

    # Find best hero for each villain
    best_match_indices = np.argmax(similarities, axis=0)

    #Print results
    for villain_idx, hero_idx in enumerate(best_match_indices):
        villain_name = data.iloc[villain_data.index[villain_idx]]['Character']
        hero_name = data.iloc[heroes_data.index[hero_idx]]['Character']
        print(f"The best hero to fight {villain_name} is {hero_name}")
    
initialize_ai()

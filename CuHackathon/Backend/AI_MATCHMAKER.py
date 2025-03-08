import pandas as pd
import tensorflow as tf
from sklearn.preprocessing import StandardScaler, OneHotEncoder, LabelEncoder


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

    # Encode categorical features
    categorical_features = ['Alignment', 'Character', 'Creator']  # List of categorical features to one-hot encode
    encoder = OneHotEncoder(sparse_output=False)  # Initialize the OneHotEncoder with dense output 

    # Convert encoded features to DataFrame
    # encoded_df = pd.DataFrame(encoded_features, columns=encoder.get_feature_names_out(categorical_features))  # Convert encoded features to DataFrame

    # Encode 'Alignment' with LabelEncoder
    label_encoder = LabelEncoder()
    data['Alignment'] = label_encoder.fit_transform(data['Alignment'])  # Encode 'Alignment' with unique numerical values
    data['Creator'] = label_encoder.fit_transform(data['Creator']) # encode 'creator'
    # Concatenate numerical, encoded categorical, and encoded 'Alignment' features
    data = pd.concat([pd.DataFrame(data[numerical_features], columns=numerical_features), data['Alignment'], data['Creator'], data['Character']], axis=1)  # Concatenate features

    # print(data.head(20))  # Print the final DataFrame
                          # 2 represent bad, 3 is good, 4 is neutral, 5 is None
                          # not including neutral or none

    data = data[data['Creator'] != 110]
    heroes_data = data[data['Alignment'] == 3]   
    villain_data = data[data['Alignment'] == 2]

    return data


def initialize_ai():

    data=parse_data()

    # Define the model
    embedding_model = tf.keras.Sequential([
    tf.keras.layers.Dense(128, activation='relu'),
    tf.keras.layers.Dense(64, activation='relu'),
    tf.keras.layers.Dense(32)  # Embedding size
    ])

    heroes_data = data[data['Alignment'] == 3]
    villain_data = data[data['Alignment'] == 2]
    # Compute embeddings for all heroes and villains
    embeddings_villain = embedding_model.predict(villain_data)
    embeddings_hero = embedding_model.predict(villain_data)

    


parse_data() 
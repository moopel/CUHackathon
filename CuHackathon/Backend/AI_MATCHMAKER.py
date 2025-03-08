import pandas as pd
import tensorflow as tf
import numpy as np
from sklearn.preprocessing import StandardScaler, LabelEncoder
from sklearn.metrics.pairwise import cosine_similarity
import random

def parse_data():
    data = pd.read_csv('assets/Superheroes.csv')

    print(data['Alignment'].unique()) 

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

    heroes_array = heroes_data.drop(columns=['Alignment']).to_numpy(dtype=np.float32)
    villains_array = villain_data.drop(columns=['Alignment']).to_numpy(dtype=np.float32)

    print(villains_array)

    ##
    # Compute embeddings
    embeddings_hero = embedding_model.predict(heroes_array)
    embeddings_villain = embedding_model.predict(villains_array)

    embeddings_hero = tf.math.l2_normalize(embedding_model.predict(heroes_array), axis=1)
    embeddings_villain = tf.math.l2_normalize(embedding_model.predict(villains_array), axis=1)

    # Compute cosine similarity
    similarities = cosine_similarity(embeddings_hero, embeddings_villain)

    # Find best hero for each villain
    best_match_indices = np.argmax(similarities, axis=0)

    print(best_match_indices)

    print(len(heroes_array))
    print(len(villains_array))


    index = random.randint(0, len(villain_data) - 1)
    
    condition=True
    count=0

    while(condition):
        try:
            villain_name = data.iloc[villain_data.index[index]]['Character']
            condition=False
        except IndexError:
            index=random.randint(0,5661)
            condition=True
            count+=1


    hero_list=[]
    for i in range(10):
        if best_match_indices[i] < 0 or best_match_indices[i] >= len(heroes_data):
            continue

        try:
            hero_name = data.iloc[heroes_data.index[best_match_indices[i]]]['Character']
        except IndexError:
            print(f'index that broke is random villian indexed {index} with a hero best match index {i}')
            count+=1
            continue


        if hero_name in hero_list:
            continue
        hero_list.append(hero_name)

    print(f"The best heros to fight {villain_name} are {hero_list} ")
    print(count)

    print(data['Alignment'].unique()) 
    print(heroes_data['Alignment'].unique())
    print(villain_data['Alignment'].unique())

    #Print results
    # for villain_idx, hero_idx in enumerate(best_match_indices):
    #     villain_name = data.iloc[villain_data.index[villain_idx]]['Character']
    #     hero_name = data.iloc[heroes_data.index[hero_idx]]['Character']
    #     print(f"The best hero to fight {villain_name} is {hero_name}")
    
initialize_ai()

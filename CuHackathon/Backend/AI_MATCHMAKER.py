import pandas as pd
import tensorflow as tf
import numpy as np
from sklearn.preprocessing import StandardScaler, LabelEncoder
from sklearn.metrics.pairwise import cosine_similarity
import random

def parse_data():
    
    
    feature_weights = {
    'Combat': 1.5,       # More weight on Combat
    'Durability': 1.0,   # Normal weight on Durability
    'Intelligence': 1.0,  # Normal weight on Intelligence
    'Power': 1.2,        # Slightly more weight on Power
    'Strength': 2.0,     # More weight on Strength
    'Speed': 0.5         # Less weight on Speed
    }


    data = pd.read_csv('assets/Superheroes.csv')

    data = data[data['Creator'].isin(['DC Comics', 'Marvel Comics','Disney','Pixar',])] # Filter by Creator


    # Ensure numerical data
    numerical_features = ['Combat', 'Durability', 'Intelligence', 'Power', 'Strength', 'Speed']
    for feature in numerical_features:
        data[feature] = pd.to_numeric(data[feature], errors='coerce')  # Convert to numeric

    for feature, weight in feature_weights.items(): #ATTEMPT TO WEIGHT FEATURES
        data[feature] = data[feature] * weight

    scaler = StandardScaler()
    data[numerical_features] = scaler.fit_transform(data[numerical_features])

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

def generate_villain(data,villain_data):
    index = random.randint(0, len(villain_data) - 1)
    villain_name = data.iloc[villain_data.index[index]]['Character']
    return villain_name

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


    ##
    # Compute embeddings
    embeddings_hero = embedding_model.predict(heroes_array)
    embeddings_villain = embedding_model.predict(villains_array)

    embeddings_hero = tf.math.l2_normalize(embedding_model.predict(heroes_array), axis=1)
    embeddings_villain = tf.math.l2_normalize(embedding_model.predict(villains_array), axis=1)

    # Compute cosine similarity
    similarities = cosine_similarity(embeddings_hero, embeddings_villain)

    print(similarities)

    # Find best hero for each villain
    best_match_indices = np.argmax(similarities, axis=0)

    

    
    condition=True
    count=0
    rand_count=0

    while(condition):
        try:
            villain_name=generate_villain(data,villain_data)#get villain name to fight
            condition=False
        except IndexError:
            rand_count+=1


    # while(condition):
    #     try:
    #         villain_name = data.iloc[villain_data.index[index]]['Character']
    #         condition=False
    #     except IndexError:
    #         index=random.randint(0,5661)
    #         condition=True
    #         count+=1


    hero_list=[]
    
    #heroes_data_reset = heroes_data.reset_index(drop=True)

    for i in range(min(len(best_match_indices), 20)):

        hero_idx = best_match_indices[i]

        if hero_idx < 0 or hero_idx >= len(heroes_data):
            continue

        try:
            hero_name = data.iloc[heroes_data.index[hero_idx]]['Character']
        except IndexError:
            print(f'index broke at {i}')
            count+=1
            continue


        if hero_name in hero_list:
            continue
        hero_list.append(hero_name)

    print(f"The best heros to fight {villain_name} are {hero_list} ")
    print(count)
    print(rand_count)

    #Print results
    # for villain_idx, hero_idx in enumerate(best_match_indices):
    #     villain_name = data.iloc[villain_data.index[villain_idx]]['Character']
    #     hero_name = data.iloc[heroes_data.index[hero_idx]]['Character']
    #     print(f"The best hero to fight {villain_name} is {hero_name}")
    
initialize_ai()

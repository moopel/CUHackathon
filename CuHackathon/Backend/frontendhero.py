# Save this as app.py or hero_matcher.py (NOT streamlit.py)
import pandas as pd
import tensorflow as tf
import numpy as np
from sklearn.preprocessing import StandardScaler, OneHotEncoder, LabelEncoder
import random
import sys
import streamlit as st
import LOAD_AI_RESPONSE
from AI_MATCHMAKER import parse_data, initialize_ai, generate_villain, return_villain_list, get_character_from_name

# Streamlit UI code below 
def main():
    st.title("Superhero vs Villain Matchmaker")

    
    # Sidebar for navigation
    page = st.sidebar.selectbox("Choose a page", ["Match Generator", "Character Explorer", "About"])
    
    if page == "Match Generator":
        st.header("Generate Hero-Villain Matches")
        
        if st.button("Generate Random Villain"):
            try:
                villain = generate_villain()
                st.write(f"Random villain generated: **{villain}**")
                
                # Use your AI to find matching heroes
                st.write("Finding best hero matches...")
                # Display results here
            except Exception as e:
                st.error(f"Error generating villain: {e}")
            
        st.subheader("Or select a specific villain:")
        try:
            villain_list = return_villain_list()
            selected_villain = st.selectbox("Choose a villain", villain_list)
            
            if st.button("Find Hero Matches"):
                # Call your matching algorithm for the selected villain
                st.write(f"Finding best heroes to fight {selected_villain}...")
                # Display results here
                st.write(f"The best heroes to fight {selected_villain} are ")
                hero_list = initialize_ai(selected_villain)
                st.write(f"{str(hero_list)}")
                st.write(f"{LOAD_AI_RESPONSE.get_bot_villain_crime(selected_villain)}")
                st.write(f"\n")
                st.write(f"\n")
                st.write(f"{str(hero_list[0])}")
                st.write(f"{LOAD_AI_RESPONSE.get_bot_hero_decription(hero_list[0], selected_villain)}")
                st.write(f"\n")
                st.write(f"\n")
                st.write(f"{str(hero_list[1])}")
                st.write(f"{LOAD_AI_RESPONSE.get_bot_hero_decription(hero_list[1], selected_villain )})")

        except Exception as e:
            st.error(f"Error loading villains: {e}")
    
    elif page == "Character Explorer":
        st.header("Explore Character Stats")
        
        try:
            # Get all character names
            data = parse_data()
            all_characters = data['Character'].unique()
            
            selected_character = st.selectbox("Select a character to explore", all_characters)
            
            if selected_character:
                character_data = get_character_from_name(selected_character)
                
                if character_data is not None:
                    # Display character stats
                    st.subheader(f"{selected_character} Stats")
                    
                    # Create columns for displaying information
                    col1, col2 = st.columns(2)
                    
                    with col1:
                        alignment_value = character_data['Alignment'].values[0]
                        alignment_text = 'Hero' if alignment_value == 3 else 'Villain'
                        st.write(f"**Alignment:** {alignment_text}")
                        st.write(f"**Creator:** {character_data['Creator'].values[0]}")
                    
                    with col2:
                        # Display numerical stats
                        numerical_features = ['Combat', 'Durability', 'Intelligence', 'Power', 'Strength', 'Speed']
                        for feature in numerical_features:
                            if feature in character_data.columns:
                                st.write(f"**{feature}:** {character_data[feature].values[0]}")
                else:
                    st.error(f"Character {selected_character} not found")
        except Exception as e:
            st.error(f"Error loading character data: {e}")
    
    else:  # About page
        st.header("About This Application")
        st.write("""
        This application uses machine learning to find the best superhero matches against villains.
        It analyzes various character attributes like Combat, Durability, Intelligence, Power, Strength, and Speed
        to determine which heroes would be most effective against specific villains.
        
        The matching algorithm uses cosine similarity on character embeddings to find the most suitable opponents.
        """)

if __name__ == "__main__":
    main()
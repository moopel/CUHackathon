import os
from openai import OpenAI
from dotenv import load_dotenv

load_dotenv()  # Load environment variables

def get_bot_villain_crime(villain_name):
    try:
        with open("CuHackathon/Backend/assets/villianPrompt.txt") as file:
            VILLIAN_PROMPT = file.read()
    except FileNotFoundError:
        return f"Files in this directory: {os.listdir()} | Current working directory: {os.getcwd()}"

    chat_messages = [
        {"role": "system", "content": VILLIAN_PROMPT},
        {"role": "user", "content": f"Generate a crime for {villain_name}."}
    ]

    # Initialize OpenAI client with API key
    api_key = os.getenv("GPT_KEY")
    if not api_key:
        return "Error: OpenAI API key not found. Check your .env file."

    client = OpenAI(api_key=api_key)

    try:
        completion = client.chat.completions.create(
            model="gpt-4o-mini",
            messages=chat_messages
        )
        response = completion.choices[0].message.content
        return response

    except Exception as e:
        return f"Error generating response: {str(e)}"


def get_bot_hero_decription(hero_name, villain_name):
    try:
        with open("CuHackathon/Backend/assets/heroPrompt.txt") as file:
            HERO_PROMPT = file.read()
    except FileNotFoundError:
        return f"Files in this directory: {os.listdir()} | Current working directory: {os.getcwd()}"
    
    chat_messages = [
        {"role": "system", "content": HERO_PROMPT},
        {"role": "user", "content": f"Generate why {hero_name} is a good match up against {villain_name}."}
    ]

    # Initialize OpenAI client with API key
    api_key = os.getenv("GPT_KEY")
    if not api_key:
        return "Error: OpenAI API key not found. Check your .env file."

    client = OpenAI(api_key=api_key)

    try:
        completion = client.chat.completions.create(
            model="gpt-4o-mini",
            messages=chat_messages
        )
        response = completion.choices[0].message.content
        return response

    except Exception as e:
        return f"Error generating response: {str(e)}"
    

def get_bot_fight_outplay(hero_name, villain_name, setting, winner):
    try:
        with open("CuHackathon/Backend/assets/fightOutplay.txt") as file:
            FIGHT_PROMPT = file.read()
    except FileNotFoundError:
        return f"Files in this directory: {os.listdir()} | Current working directory: {os.getcwd()}"
    
    chat_messages = [
        {"role": "system", "content": FIGHT_PROMPT},
        {"role": "user", "content": f"Generate the decription of how {hero_name} fights {villain_name}  while the the setting is {setting} and {winner} wins."}
    ]

    # Initialize OpenAI client with API key
    api_key = os.getenv("GPT_KEY")
    if not api_key:
        return "Error: OpenAI API key not found. Check your .env file."

    client = OpenAI(api_key=api_key)

    try:
        completion = client.chat.completions.create(
            model="gpt-4o-mini",
            messages=chat_messages
        )
        response = completion.choices[0].message.content
        return response

    except Exception as e:
        return f"Error generating response: {str(e)}"

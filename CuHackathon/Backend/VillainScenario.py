import os
from openai import OpenAI
from dotenv import load_dotenv

load_dotenv()  # Load environment variables

def get_bot_response(villain_name):
    try:
        with open("assets/villianPrompt.txt") as file:
            VILLAIN_PROMPT = file.read()
    except FileNotFoundError:
        return f"Files in this directory: {os.listdir()} | Current working directory: {os.getcwd()}"

    chat_messages = [
        {"role": "system", "content": VILLAIN_PROMPT},
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



print(get_bot_response("joker"))

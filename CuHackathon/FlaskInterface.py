from flask import Flask, request, jsonify
import os
import sys
from openai import OpenAI
from dotenv import load_dotenv

sys.path.append(os.path.join(os.path.dirname(__file__), "Backend"))

from LOAD_AI_RESPONSE import get_bot_villain_crime, get_bot_hero_decription, get_bot_fight_outplay

app = Flask(__name__)
load_dotenv()

@app.route('/generate-crime', methods=['POST'])
def generate_crime():
    data = request.get_json()
    villain_name = data.get('villain_name')
    result = get_bot_villain_crime(villain_name)
    return jsonify({"crime": result})

@app.route('/generate-hero-description', methods=['POST'])
def generate_hero_description():
    data = request.get_json()
    hero_name = data.get('hero_name')
    villain_name = data.get('villain_name')
    result = get_bot_hero_decription(hero_name, villain_name)
    return jsonify({"description": result})

@app.route('/generate-fight', methods=['POST'])
def generate_fight():
    data = request.get_json()
    hero_name = data.get('hero_name')
    villain_name = data.get('villain_name')
    setting = data.get('setting')
    winner = data.get('winner')
    result = get_bot_fight_outplay(hero_name, villain_name, setting, winner)
    return jsonify({"fight": result})

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)

import pandas as pd # import pandas for reading in data
from sklearn.preprocessing import StandardScaler, OneHotEncoder

data = pd.read_csv('assets/Superheroes.csv')

scaler = StandardScaler()
numerical_features = ['Combat', 'Durability', 'Intelligence', 'Power', 'Strength', 'Speed'] # list of numeric data parsed
print(data.columns)
# data[numerical_features] = scaler.fit_transform(data[numerical_features])

def get_villain_name():
    pass

import pandas as pd
from sklearn.preprocessing import StandardScaler, OneHotEncoder

data = pd.read_csv('assets/Superheroes.csv')


numerical_features = ['Combat', 'Durability', 'Intelligence', 'Power', 'Strength', 'Speed'] # numeric data to parse
for feature in numerical_features:
    data[feature] = pd.to_numeric(data[feature], errors='coerce') # convert data to numeric

# Handle missing values (e.g., fill with the mean of the column)
data[numerical_features] = data[numerical_features].fillna(data[numerical_features].mean())  # Fill NaN values with the mean of each column

scaler = StandardScaler()  # Initialize the StandardScaler
data[numerical_features] = scaler.fit_transform(data[numerical_features])  # Scale the numerical features

categorical_features = ['Character', 'Creator', 'Alignment']  # List of categorical features to encode
encoder = OneHotEncoder(sparse_output=False)  # Initialize the OneHotEncoder with dense output
encoded_features = encoder.fit_transform(data[categorical_features])  # Fit and transform the categorical features

# Convert encoded features to DataFrame and concatenate with numerical features
# encoded_df = pd.DataFrame(encoded_features, columns=encoder.get_feature_names_out(categorical_features))  # Convert encoded features to DataFrame
# data = pd.concat([pd.DataFrame(data[numerical_features], columns=numerical_features), encoded_df], axis=1)  # Concatenate numerical and encoded categorical features


for feature in categorical_features:
    data[feature] = encoder.fit_transform(data[feature])

print(data)  # Print the final DataFrame
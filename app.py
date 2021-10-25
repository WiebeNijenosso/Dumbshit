from flask import Flask, json

api = Flask(__name__)

data = {"id": 1, "name": "Dect", "Status": 1}


@api.route('/', methods=['GET'])
def dectcon():
    return json.dumps(data)

if __name__ == '__main__':
    api.run(debug=True, host='0.0.0.0')
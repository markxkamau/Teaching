from flask import Flask, request

app = Flask(__name__)


@app.route("/")
def home():
    return "Hello World"


@app.route("/mapping", methods=["GET", "POST"])
def index():
    if request.method == "GET":
        return "This is a GET request"
    elif request.method == "POST":
        return "This is a POST request"


if __name__ == "__main__":
    app.run()

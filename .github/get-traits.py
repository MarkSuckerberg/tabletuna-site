#!/usr/bin/env python3

from bs4 import BeautifulSoup
import requests
import json
import re

page = requests.get('https://cosmosdex.com/cosmosdex/traits/')
soup = BeautifulSoup(page.text, 'html.parser')

list_elems = soup.find_all("div", class_="dexsectiontextmiddle")
list_traits = []

for elem in list_elems:
    result = {}
    if elem.find(["div", "a"], class_="bluetrait"):
        result["value"] = 0
    elif elem.find(["div", "a"], class_="greentrait"):
        result["value"] = 1
    elif elem.find(["div", "a"], class_="redtrait"):
        result["value"] = 2
    elif elem.find(["div", "a"], class_="purpletrait"):
        result["value"] = 3
    elif elem.find(["div", "a"], class_="yellowtrait"):
        result["value"] = 4
    else:
        print(f"error! {elem}")

    result["name"] = elem.find("a").string.strip("[]")
    result["effects"] = elem.find("p").string or str(elem.find("p")) #re.sub('<[^<]+?>', '', str(elem.find("p"))) #Uncomment if you want to strip all html tags from the strings.

    list_traits.append(result)

list_traits.sort(key=lambda word:word["name"])

with open("traits.json", "w") as write_file:
    json.dump(list_traits, write_file)

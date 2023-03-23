# for loop that iterates for each file object in thet list files
for file in files:
        # 
        with open(CONST_PATH + file, 'r') as f:
            data = json.load(f)
            keys = list(data.keys())
            keys.sort (key = lambda x:data[x]['time'],reverse=False)

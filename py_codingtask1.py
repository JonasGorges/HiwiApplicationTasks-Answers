# for loop that iterates for each file object in thet list files
for file in files:
        # opens in read-only mode the file with the path constructed of the "CONST_PATH" and the file name, saves the content of the file as variable f
        with open(CONST_PATH + file, 'r') as f:
            # declares the variable "data" and puts in json format the content of variable f inside
            data = json.load(f)
            # declares the variable "keys" and creates a list of the keys values in data (what is previously initialized in line 6)
            keys = list(data.keys())
            # uses the "sort" function to sort the keys by the "time" as lambda input to sort the keys in ascending order (because reverse is set to "False")
            keys.sort (key = lambda x:data[x]['time'],reverse=False)
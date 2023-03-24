# HiwiApplicationTasks-Answers


## 1) Motivation

During my architecture study I have already worked as Hiwi for the ICD on RP 11/12 and it was an enriching and fun experience.
So I applied again initially for a Hiwi position and was relatively open in which area I find something. I thought that in every case I am able to learn something and can use my already existing knowledge to help. Since my first Hiwi Job I have focused my studies in the direction of integrated digital design and fabrication (for example with the ICD Seminars and projects, like  the AAD Seminar with Zuardin and Prof. Wortmann). Nevertheless, I would by no means describe myself as a computer scientist, rather as an architect with an affinity to computation and computerization. 
I think that with the help of digital tools and advantages computer-aided design have modern architecture can be improved and optimized in terms of sustainability, cost and efficiency. But with all the possibilities it has for the design and construction process it is important to respect the essence of architecture, that it should be created for the people, respecting and integrating the environment and nature to create spaces with meaning.

## 2) Self Assessment

How do you rate your Python and C# skills?

- basic knowledge of code structures and object oriented programming
- more experience in python than in C#
- actually 5 years ago when I actively did something in C++ and C# (during my electronical engineering/ information technologies study)
- have to get used to the syntax and script environment again, but I am motivated to catch up on missing knowledge

## 3) Coding Tasks

1. Briefly explain the two code snippets you can find in this repo.

C# Code:
Sorts out keys with the values less than the "upperBound" (=10) of the Dictionary "someDict" and saves these keys into a new list with the name "someNewDict". It also calls a filling function with the "someDict" Dictionary before (that is not explained in the code snippet).

Python Code:
Reading json data from a list of files, sorting the keys by the attribute "time" in ascending order (I guess the time is the timestamp of the file).
This sorting process is done for every file in the filelist.

Additional task, not required:

2. Please implement a "named pipe" for exchanging double arrays between a C# and Python process.

Because the Python code is already reading json data I used the Json Serializer to save a list in the C# code as json file.
This is done in a sperate function that is called afterwards. In this way data from a C# list can be used in Python.
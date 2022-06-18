import math

personsN = int(input())
capacity = int(input())

if (capacity > personsN):
    print(1)
else:
    courses = math.ceil(personsN / capacity)
    print(courses)
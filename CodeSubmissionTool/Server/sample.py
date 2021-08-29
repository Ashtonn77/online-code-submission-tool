import sys

a = sys.argv[1]

def test(a):
    return a[::-1]
    
print(test(a))    
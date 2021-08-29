import sys

n = sys.argv[1]

def fizzBuzz(n):
    x = int(n)
    
    res = ""
    
    for i in range(1, x + 1):
        
        if i % 3 == 0 and i % 5 == 0:
            res += "FizzBuzz"
        elif i % 3 == 0:
            res += "Fizz"
        elif i % 5 == 0:
            res += "Buzz"
        else:
            res += str(i)
            
    return res
    
print(fizzBuzz(n))    
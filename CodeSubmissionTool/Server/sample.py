import sys

sentence = sys.argv[1]

def checkIfPangram(sentence):
    
    alphabets_small = "abcdefghijklmnopqrstuvwxyz"
    alphabets_big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            
    sentence = list(set(sentence))
    sentence = sorted(sentence)
    sentence = "".join(sentence)
    if sentence in alphabets_small or sentence in alphabets_big:
        if len(sentence)==26:
            return True

    else:
        return False
        
print(checkIfPangram(sentence))
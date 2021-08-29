import sys

s = sys.argv[1]

def isValid(s) -> bool:
    stack=[]
    comb={'(':')','{':'}','[':']'}
    for brkt in s:
        if brkt in comb.keys():
            stack.append(brkt)
        else:
            if len(stack)>0 and comb[stack[-1]]==brkt:
                stack.pop()
            else:
                return False
    return len(stack)==0
        
print(isValid(s))
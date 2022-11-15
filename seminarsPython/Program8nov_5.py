def Mix():
    b=[]
    #b=[i for i in range(0, a)]
    v=[int(x) for x in input().split(' ')]
    #for i in range(len(v)):
    #while(v):
        #b+=[int(v)] #input())]
        #v=input().split(' ')
    b=v
    #print(b)
    for i in range(0, len(b)): # 0, 
        #print(b)
        if i%2==0 and i!=0:
            if i!=len(b)-1:
                k=b[i]
                b[i]=b[i+1]
                b[i+1]=k
        else:
            if i==0:
                k=b[i]
                b[i]=b[i+1]
                b[i+1]=k
            else:
                if i==1:    
                    #else:
                    if i!=len(b)-1 and i!= 0 and b[i+1]: #i!=0:
                        k=b[i]
                        b[i]=b[i+1]
                        b[i+1]=k
    for i in range(len(b)):
        print('%d ' %b[i])    
    #print(b)

Mix()
def Mix():
    b=[]
    #b=[i for i in range(0, a)]
    v=input()
    while(v):
        b+=[int(v)] #input())]
        v=input()
    print(b)
    for i in range(0, len(b)):
        if i%2==0:
            if i!=len(b)-1:
                k=b[i]
                b[i]=b[i+1]
                b[i+1]=k
        else:
            if b[i+1]: #i!=0:
                k=b[i]
                b[i]=b[i-1]
                b[i-1]=k
    print(b)

Mix()
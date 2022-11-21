# Считайте элементы и сформируйте из него список. Реализуйте следующий алгоритм перемешивания списка: Необходимо пройтись по всем элемента от 0 до последнего один раз и каждый четный элемент поменять местами 
# с предыдущим, каждый нечетный со следующим, если такое возможно. 
# в промежутке от 0-го до последнего элемента, не нарушая предыдущих правил и уже сделанных перемещений на промежутке от 0-го до текущего элемента.
def Mix():
    b=[]
    v=[int(x) for x in input().split(' ')]
    b=v
    flag=False
    #print(b)
    for i in range(1, len(b)-1, 2): 
        print(b)
        #if i%2==0 and i<len(b)-1 and not flag: # and i!=0:
        #if i!=len(b)-1:
        if i%2==0 and not flag:
            k=b[i]
            b[i]=b[i-1]
            b[i-1]=k
            flag=False
        else:
            if i%2 !=0:
                k=b[i]
                b[i]=b[i+1]
                b[i+1]=k
                flag=True
        # k=b[i]
        # b[i]=b[i+1]
        # b[i+1]=k
        # flag=True
        # else:
        #     if i%2 !=0 and i<len(b)-1 and not flag:
        #         #if i%2 !=0:
        #         k=b[i]
        #         b[i]=b[i-1]
        #         b[i-1]=k
        #         flag=False
        #     else:
        #         if i==len(b)-1 or i%2 !=0 and not flag:
        #             k=b[i]
        #             b[i]=b[i-1]
        #             b[i-1]=k
        #             flag=False
    #if          # проверить на четность последний из элементов и если он четный, то поменять его местами с предыдущим
    # if len(b)%2==0:
    #     k=b[len(b)-1]
    #     b[len(b)-1]=b[len(b)-2]
    #     b[len(b)-2]=k      
                
    for i in range(len(b)):
        print('%d ' %b[i])    
    #print(b) 

Mix()
        
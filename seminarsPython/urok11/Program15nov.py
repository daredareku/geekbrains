# #
# Формат: Объясняет преподаватель

# Задача: предложить улучшения кода для уже решённых задач:

# С помощью использования **лямбд, filter, map, zip, enumerate, list comprehension
# В этом случае можно пропустить совсем тривиальные (т.е. задачу 1 или 2 тут точно решать не имеет смысла) - исходите из уровня группы и студента.
lst=list(map(int, input().split()))
ukicum=list(set(lst)) #.difference()
print(ukicum)

lst=input().split()
result_list=list(filter(None, lst))

lst = list(map(int, input().split()))
unikum = list(set(lst)) 
print(unikum)  

lst = input().split()
result_list = list(filter(lambda x: (lst.count(x) == 1), lst))
print(result_list)      

exp = str(input())
res = eval(exp)
print(res)


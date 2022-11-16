#
# Урок 5. Ускоренная обработка данных: lambda, filter, map, zip, enumerate, list comprehension
# 1. Напишите программу, удаляющую из текста все слова, содержащие ""абв"".
def aDelete():
    a=input("1. Введите текст: ")
    b=a.split()
    txt=a
    print(f"Исходный текст: {txt}")
    find_txt = "абв"
    lst = [i for i in txt.split() if find_txt not in i]
    print(f'Результат: {" ".join(lst)}')
# 2. Создайте программу для игры с конфетами человек против человека.

# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет. 
# Все конфеты оппонента достаются сделавшему последний ход. Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?

# a) Добавьте игру против бота

# b) Подумайте как наделить бота ""интеллектом""
def candy():
    print("2. Игра в конфеты")
    print("1 - играть с ботом")
    print("2 - играть с другом")
    print("3 - играть с ИИ")
    print("4 - выход")
    a=int(input("Выберите действие: "))
    if a==1:
        print("Игра с ботом")
        candyBot()
    elif a==2:
        print("Игра с другом")
        print("Human with human")
        candyHumanwithhuman()
    elif a==3:
        print("Игра с ботом AI")
        bot_candy()
    elif a==4:
        print("Выход")
    else:
        print("Неверный ввод")
        candy()

from random import randint

def input_dat(name):
    x = int(input(f"{name}, введите количество конфет, которое возьмете от 1 до 28: "))
    while x < 1 or x > 28:
        x = int(input(f"{name}, введите корректное количество конфет: "))
    return x


def p_print(name, k, counter, value):
    print(f"Ходил {name}, он взял {k}, теперь у него {counter}. Осталось на столе {value} конфет.")

def input_dat(name):
    x = int(input(f"{name}, введите количество конфет, которое возьмете от 1 до 28: "))
    while x < 1 or x > 28:
        x = int(input(f"{name}, введите корректное количество конфет: "))
    return x

def p_print(name, k, counter, value):
    print(f"Ходил {name}, он взял {k}, теперь у него {counter}. Осталось на столе {value} конфет.")

from random import randint

def candyHumanwithhuman():
    # вариант человек против человека:
    player1 = input("Введите имя первого игрока: ")
    player2 = input("Введите имя второго игрока: ")
    value = int(input("Введите количество конфет на столе: "))
    flag = randint(0,2) # флаг очередности
    if flag:
        print(f"Первый ходит {player1}")
    else:
        print(f"Первый ходит {player2}")

    counter1 = 0 
    counter2 = 0

    while value > 28:
        if flag:
            k = input_dat(player1)
            counter1 += k
            value -= k
            flag = False
            p_print(player1, k, counter1, value)
        else:
            k = input_dat(player2)
            counter2 += k
            value -= k
            flag = True
            p_print(player2, k, counter2, value)

    if flag:
        print(f"Выиграл {player1}")
    else:
        print(f"Выиграл {player2}")
    
# вариант человек против бота:
from random import randint

def input_dat(name):
    x = int(input(f"{name}, введите количество конфет, которое возьмете от 1 до 28: "))
    while x < 1 or x > 28:
        x = int(input(f"{name}, введите корректное количество конфет: "))
    return x


def p_print(name, k, counter, value):
    print(f"Ходил {name}, он взял {k}, теперь у него {counter}. Осталось на столе {value} конфет.")

def candyBot():
    player1 = input("Введите имя первого игрока: ")
    player2 = "Bot"
    value = int(input("Введите количество конфет на столе: "))
    flag = randint(0,2) # флаг очередности
    if flag:
        print(f"Первый ходит {player1}")
    else:
        print(f"Первый ходит {player2}")

    counter1 = 0 
    counter2 = 0

    while value > 28:
        if flag:
            k = input_dat(player1)
            counter1 += k
            value -= k
            flag = False
            p_print(player1, k, counter1, value)
        else:
            k = randint(1,29)
            counter2 += k
            value -= k
            flag = True
            p_print(player2, k, counter2, value)

    if flag:
        print(f"Выиграл {player1}")
    else:
        print(f"Выиграл {player2}")
    
# вариант человек против бота c "интеллектом":
from random import randint

def input_dat(name):
    x = int(input(f"{name}, введите количество конфет, которое возьмете от 1 до 28: "))
    while x < 1 or x > 28:
        x = int(input(f"{name}, введите корректное количество конфет: "))
    return x


def p_print(name, k, counter, value):
    print(f"Ходил {name}, он взял {k}, теперь у него {counter}. Осталось на столе {value} конфет.")


def bot_calc(value):
    k = randint(1,29)
    while value-k <= 28 and value > 29:
        k = randint(1,29)
    return k

def bot_candy(): # AI for
    player1 = input("Введите имя первого игрока: ")
    player2 = "Bot"
    value = int(input("Введите количество конфет на столе: "))
    flag = randint(0,2) # флаг очередности
    if flag:
        print(f"Первый ходит {player1}")
    else:
        print(f"Первый ходит {player2}")

    counter1 = 0 
    counter2 = 0

    while value > 28:
        if flag:
            k = input_dat(player1)
            counter1 += k
            value -= k
            flag = False
            p_print(player1, k, counter1, value)
        else:
            k = bot_calc(value)
            counter2 += k
            value -= k
            flag = True
            p_print(player2, k, counter2, value)

    if flag:
        print(f"Выиграл {player1}")
    else:
        print(f"Выиграл {player2}")    
    
# 3. Создайте программу для игры в ""Крестики-нолики"".
    
def crestikiNoliki():
    print("3. Игра в крестики-нолики")
    print("1 - играть с ботом")
    print("2 - играть с другом")
    print("3 - выход")
    a=int(input("Выберите действие: "))
    if a==1:
        print("Игра с ботом")
        print("Not implemented")
    elif a==2:
        print("Игра с другом")
        main(board=board)
        #crestiki()
    elif a==3:
        print("Выход")
    else:
        print("Неверный ввод")
        crestikiNoliki()
        
def draw_board(board):
    print("-" * 13)
    for i in range(3):
        print("|", board[0+i*3], "|", board[1+i*3], "|", board[2+i*3], "|")
        print("-" * 13)

def take_input(player_token):
    valid = False
    while not valid:
        player_answer = input("Куда поставим " + player_token+"? ")
        try:
            player_answer = int(player_answer)
        except:
            print("Некорректный ввод. Вы уверены, что ввели число?")
            continue
        if player_answer >= 1 and player_answer <= 9:
            if(str(board[player_answer-1]) not in "XO"):
                board[player_answer-1] = player_token
                valid = True
            else:
                print("Эта клетка уже занята!")
        else:
            print("Некорректный ввод. Введите число от 1 до 9.")

def check_win(board):
   win_coord = ((0,1,2), (3,4,5), (6,7,8), (0,3,6), (1,4,7), (2,5,8), (0,4,8), (2,4,6))
   for each in win_coord:
       if board[each[0]] == board[each[1]] == board[each[2]]:
          return board[each[0]]
   return False

def main(board): # crestikiNoliki
    counter = 0
    win = False
    while not win:
        draw_board(board)
        if counter % 2 == 0:
           take_input("X")
        else:
           take_input("O")
        counter += 1
        if counter > 4:
           tmp = check_win(board)
           if tmp:
              print(tmp, "выиграл!")
              win = True
              break
        if counter == 9:
            print("Ничья!")
            break
    draw_board(board)
    
# 4. Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.

# Входные и выходные данные хранятся в отдельных текстовых файлах.
def aRLE(t):
    print("4. RLE алгоритм")
    print("1 - сжатие")
    print("2 - восстановление")
    print("3 - сжатие и восстановление")
    print("4 - выход")
    a=int(input("Выберите действие: "))
    if a==1:
        print("Сжатие")
        print(f"Текст после кодировки: {codingRLE(t)}")
    elif a==2:
        print("Восстановление")
        print(f"Текст после дешифровки: {decodingRLE(t)}")
    elif a==3:
        tt=f"Текст после кодировки: {codingRLE(t)}"
        print(tt)
        print("Восстановление")
        print(f"Текст после дешифровки: {decodingRLE(tt)}")
    elif a==4:
        print("Выход")
    else:
        print("Неверный ввод")
        aRLE(t)
        
def codingRLE(atxt):
    count = 1
    res = ''
    for i in range(len(atxt)-1):
        if atxt[i] == atxt[i+1]:
            count += 1
        else:
            res = res + str(count) + atxt[i]
            count = 1
    if count > 1 or (atxt[len(atxt)-2] != atxt[-1]):
        res = res + str(count) + atxt[-1]
    return res

def decodingRLE(atxt):
    number = ''
    res = ''
    for i in range(len(atxt)):
        if not atxt[i].isalpha() and atxt[i].isdigit():
            number += atxt[i]
        else:
            try:
                res = res + (atxt[i] * int(number))
                number = ''
            except:
                res = res + atxt[i]
    return res

def rle_decode(data): 
    decode = '' 
    count = '' 
    for char in data: 
        # If the character is numerical... 
        if char.isdigit(): 
            # ...append it to our count 
            count += char 
        else: 
            # Otherwise we've seen a non-numerical 
            # # character and need to expand it for 
            # # the decoding 
            decode += char * int(count) 
            count = '' 
    return decode
     
aDelete()    
candy()
print("*" * 10, " 3. Игра Крестики-нолики для двух игроков ", "*" * 10)
board = []
print("Нажмите Enter для выхода!")
board = list(range(1,13)) 
crestikiNoliki()
atxt=input("4. Введите текст для кодировки: ")
aRLE(atxt)
# Copilot helper
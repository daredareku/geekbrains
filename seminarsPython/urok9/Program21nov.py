# 1. Создайте программу для игры в ""Крестики-нолики"" при помощи виртуального окружения и PIP.
# 2. Прикрутить бота к задачам с предыдущего семинара:
# 3. Создать калькулятор для работы с рациональными и комплексными числами, организовать меню, добавив в неё систему логирования
# 4. Создать телефонный справочник с возможностью импорта и экспорта данных в нескольких форматах.
# добавить кодировку UTF-8 +, на основе имеющегося кода.
#def 

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
    
    
print("*" * 10, " 3. Игра Крестики-нолики для двух игроков ", "*" * 10)
board = []
print("Нажмите Enter для выхода!")
board = list(range(1,13)) 
crestikiNoliki()


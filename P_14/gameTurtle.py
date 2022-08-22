
from ctypes.wintypes import RGB
from turtle import *        # импорт всех методов и комманд turtle
from random import *        # импорт только randint
from time import *          # импорт всех методов и команд time
from cgitb import text
from typing import Text
from tkinter.colorchooser import askcolor

finish = 350                # дистанция гонки

fin = Turtle()              # создали объект класса надписи
fin.color('green')          # задали цвет надписи
fin.penup()                 #  задали верх надписи
fin.goto(-50, 300)          # задали координаты надписи
         

# НЕ УДАЛОСЬ СДЕЛАТЬ ВЫБОР ЦВЕТА РАНДОМНО :-(

# for i in range(3):
#     r = randint(0,255)
#     g = randint(0,255)
#     b = randint(0,255)
#     rgb = [r,g,b]

t1 = Turtle()               # создали объект класса черепахи
t1.shape("turtle")          # поменяли форму объекта - создали форму черепахи
t1.color("red")             # поменяли цвет
t1.penup()                  # поднимаем черепашку, чтобы не рисовала
t1.goto(-350, 100)          # перемещаем черепашку по координатам
t1.pendown()                # опускаем черепашку, чтобы потом рисовала

t2 = Turtle()               # создали объект класса черепахи
t2.shape("turtle")          # поменяли форму объекта - создали форму черепахи
t2.color("blue")            # поменяли цвет
t2.penup()                  # поднимаем черепашку, чтобы не рисовала
t2.goto(-350, -100)         # перемещаем черепашку по координатам
t2.pendown()                # опускаем черепашку, чтобы потом рисовала


def razmetka():
    t = Turtle()            # функция рисует разметку поля
    #t = speed(10)          # с этой строкой программа НЕ РАБОТАЕТ!!!!!
    for i in range (8):
        t.penup()
        t.goto(-350 + i * 100, 250)
        t.pendown()
        t.goto(-350 + i * 100, - 250)
        t.speed(0)
    t.hideturtle()

razmetka()

fin.write('СОРЕВНОВАНИЕ ЧЕРЕПАШЕК!', font = ('Arial', 16, 'normal'))
fin.penup()                     #  задали верх надписи
fin.goto(-50, 270)              # задали координаты надписи

def catch1(x, y):                                       # это обработчик события нажатия
    t1.write('Ouch!', font = ('Arial', 14, 'normal'))   # пишем на экране: Ouch!
    t1.fd(randint(20, 25))                              # черепашка делает случайный шаг от 10 до 15
    
t1.onclick(catch1)                                      # прикрепляем обработчик к событию нажатия на 1 черепашку 

def catch2(x, y):                                       # это обработчик события нажатия
    t2.write('Ай!!!', font = ('Arial', 14, 'normal'))   # пишем на экране: Ай!!!
    t2.fd(randint(20, 25))                              # черепашка делает случайный шаг от 10 до 15
    
t2.onclick(catch2)                                      # прикрепляем обработчик к событию нажатия на 2 черепашку 

while t1.xcor() < finish or t2.xcor() < finish:
    t1.forward(randint(24, 28))
    t1.right(randint(1, 3))
    t1.left(randint(1, 3))
    t2.forward(randint(24, 28))
    t2.left(randint(1, 3))
    t2.right(randint(1, 3))
    if t1.xcor() >= finish and t2.xcor() >= finish:
        if t1.xcor() > t2.xcor():
            fin.write('Ура, победила красная черепашка', font = ('Arial', 16, 'normal'))
            sleep(5)
        else:
            fin.write('Ура, победила синяя черепашка', font = ('Arial', 16, 'normal'))
            sleep(5)
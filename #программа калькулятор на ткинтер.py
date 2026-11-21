#программа калькулятор на ткинтер
from tkinter  import *
from tkinter import messagebox
from tkinter import ttk
import math
#функция ввода числа
#суть данного метода  
# самая первая строка 
# у нас есть метод get
# и он получает введенное
# значение в переменную value 
# 
# далее мы провеям если ввел ли пользователь число и далее
# программа убирает лишний символ и знак  и 0#
#создание окна

root = Tk() #создаем корневой обьект - окно
root['bg'] = '#6B7170'
root.title("калькулятор на tkinter")
root.geometry("400x500") #установка размера окна
Label = Label(text="калькулятор на tkinter")#создаем текстовую метку
Label.pack
#централизуем кнопки
#насторойка центра сетки grid для того чтобы кнопки стояли по центру
#мы говорим растягивай пустоту  по краям  колонки (0, 6) а центр  (1,2,3,4) не трогай 
root.grid_rowconfigure(0,weight=1)#растягиваем пустому сверху
root.grid_rowconfigure(7, weight=1)#растягиваем пустомму строку(7 строка после моих кнопок)
root.grid_columnconfigure(0, weight=1)#раятягиваем пустоту слева
root.grid_columnconfigure(0, weight=1)#растягиваем пустоу справа

#создание поле ввода
calculator = Entry(tk,justify=RIGHT, font=('Times new roman',15), width=15)#задаем стиль шрифта и расположение текста в правом краю экрана
calculator.insert(0, '0')#изначальное значение на экране
calculator.grid(row=0, column=0, columnspan=3,padx=5,pady=5, sticky="we")
def add_digit_buttons(digit):
    value = calculator.get()
    if value =="":
        value = "0"  #пустое поле
    if value[0]=="0" and digit !=0:
      value = ""
    calculator.delete(0, END)
    calculator.insert(0, value+str(digit))
#функция добавления операции
def add_operations(operation):
   value = calculator.get()
   if value[-1] in '-+/*': #если пользователь ввел знак и число то
      value = value[:-1]      #то дальше мы добавляем в текстбокс только одно число втрое не всиавялется  
      #далее вызывпем функцию счета calculate если введен знак
   elif '+' in value or '-' in value or '*' in value or '/' in value:
       calculate()
       value = calculator
   calculator.delete(0, END) #очищаем поле от значений 
   calculator.insert(0, value + operation) #вставляем значение и знак операции
#функция рассчета выражения

def calculate(value):
  value = calculator.get()
  # 
  # смысл данной функции в том что
  # она уже считает значение выражения
  # когда пользоватедь-ль вводит знак
  if value[-1] in '-+/*':
      value = value+value[:-1]
  calculate.delete(0, END)
  #обработка исклбчений
  try:
      #вставляем значение в поле ввода
      calculator.insert(0, eval(value))#данная строка счет
  except (NameError, SyntaxError):
      messagebox.showerror("вы ввели число ошибка")
      #вставялем 0
      calculator.insert(0, 0)
def add_sqrt(value):
    value = calculator.get()
    value = float(value)
    value = math.sqrt
    calculator.delete(0, END)
    calculator.insert(0,value)
#функция добавления косинуса
def add_cos():
    value = add_cos
    value = calculator.get()
    value = float(value)
    value = math.cos
    calculator.delete(0, END)
    calculator.insert(0,value)
def add_sin():
    value = add_sin
    value = calculator.get()
    value = float(value)
    value = math.sin
    calculator.delete(0, END)
    calculator.insert(0,value)

#функция очистки
def clear(value):
    calculator.delete(0, END)
    calculator.insert(0, 0)
#функции отвечающие за кнопки
#функция создания кнопок калькулятора
def make_calculator_buttons(digit):
    return Button(text='=',width=4,height=2, bd=5, font=('times  New Roman', 13), command=calculate)
#функция для вызова кнопки удаления
def make_clear_button(value):
     return Button(text="C",width=4,height=2, bd=5, font=('times  New Roman', 13), command=clear)
def make_sqrt_button():
    return Button(text=add_sqrt,width=4,height=2, bd=5, font=('times  New Roman', 13), command=add_sqrt)
def make_sin_buttons(add_sin):
    return Button(text="sin",width=4,height=2, bd=5, font=('times  New Roman', 13), command=add_sin)
def make_cos_buttons(add_cos):
    return Button(text="cos", bd=5, font=('times  New Roman', 13), command=add_cos)
def make_buttons_calculate(value):
    return Button(text=value,width=4,height=2, bd =5,font=('times  New Roman', 13), command=calculate)
    
def add_sqrt_buttons():
    return Button(text="sqrt",width=5, height=2,bd =5,font=('times  New Roman', 13), command=add_sqrt)
def make_digit_button(digit):
    return Button(tk,text=digit, bd=5, font=('times New Roman', 13), command=lambda:make_digit_button)
#расплогагаем кнопки
make_digit_button('7').grid(row=1, column=0, padx=5, pady=5)
make_digit_button('8').grid(row=1, column=1, padx=5, pady=5)
make_digit_button('9').grid(row=1, column=2, padx=5, pady=5)

#кнопки синуса коиссинусв
#add_sin('sin').grid(row=3, column=2, padx=5, pady=5)
#add_cos('cos').grid(row=3, column=2, padx=5, pady=5)
# 4 5 6 (средний ряд)
make_digit_button('4').grid(row=2, column=0, padx=5, pady=5)
make_digit_button('5').grid(row=2, column=1, padx=5, pady=5)
make_digit_button('6').grid(row=2, column=2, padx=5, pady=5)

# 1 2 3 (нижний ряд)
make_digit_button('1').grid(row=3, column=0, padx=5, pady=5)
make_digit_button('2').grid(row=3, column=1, padx=5, pady=5)
make_digit_button('3').grid(row=3, column=2, padx=5, pady=5)

# 0 и знак равно
make_digit_button('0').grid(row=4, column=0, columnspan=2, padx=5, pady=5) # растянем на 2 колонки
make_calculator_buttons('=').grid(row=4, column=2, padx=5, pady=5)
#кнопки сложения и корня 
#add_sqrt('sqrt').grid(row=4,column=2,padx=5,columnspan=2, pady=5)
make_buttons_calculate('+').grid(row=4,column=2,padx=5,columnspan=2, pady=5)
make_buttons_calculate('-').grid(row=5,column=2,padx=5,columnspan=2, pady=5)
make_buttons_calculate('*').grid(row=6,column=2,padx=5,columnspan=2, pady=5)
make_buttons_calculate('/').grid(row=7,column=2,padx=5,columnspan=2, pady=5)
root.mainloop()   
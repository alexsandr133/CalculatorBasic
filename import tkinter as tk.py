import tkinter as tk
from tkinter import messagebox
import math

# 1. Создаем ОДНО главное окно (объект tk)
tk_root = tk.Tk()
tk_root.title("Калькулятор на tkinter")
tk_root.geometry("340x460")
tk_root.resizable(False, False) # Запрещаем менять размер окна

# 2. Настраиваем сетку (grid), чтобы кнопки стояли ровно по центру
# Мы говорим окну: "растягивай пустоту по краям (колонки 0 и 6), а центр (1,2,3,4) не трогай"
tk_root.grid_columnconfigure(0, weight=1)
tk_root.grid_columnconfigure(6, weight=1)
tk_root.grid_rowconfigure(0, weight=1)
tk_root.grid_rowconfigure(8, weight=1)

# 3. Создаем поле ввода (экран калькулятора)
# justify=RIGHT выравнивает текст по правому краю, как в настоящем калькуляторе
calculator = tk.Entry(tk_root, justify="right", font=('Times New Roman', 18), width=15)
calculator.insert(0, "0") # При запуске там сразу стоит 0
calculator.grid(row=1, column=1, columnspan=4, padx=5, pady=10, sticky="we")

# 4. ЛОГИКА ВЫЧИСЛЕНИЙ (функции, которые срабатывают при нажатии кнопок)

# Ввод цифр
def add_digit_buttons(digit):
    value = calculator.get()
    # Если на экране только "0", стираем его перед вводом новой цифры
    if value == "0" and digit != ".":
        value = ""
    # Если была ошибка, тоже стираем
    elif value == "Ошибка":
        value = ""
    
    calculator.delete(0, tk.END)
    calculator.insert(0, value + str(digit))

# Ввод знаков операций (+, -, *, /)
def add_operations(operation):
    value = calculator.get()
    if value == "Ошибка": return
    
    # Если последний символ уже знак, заменяем его на новый
    if value[-1] in "-+/*":
        value = value[:-1]
    calculator.delete(0, tk.END)
    calculator.insert(0, value + operation)

# Очистка (кнопка C)
def clear():
    calculator.delete(0, tk.END)
    calculator.insert(0, "0")

# Удаление последнего символа (кнопка <)
def backspace():
    value = calculator.get()
    if len(value) > 1:
        calculator.delete(len(value)-1, tk.END)
    else:
        calculator.delete(0, tk.END)
        calculator.insert(0, "0")

# Подсчет результата (кнопка =)
def calculate():
    value = calculator.get()
    try:
        # Если выражение заканчивается на знак, убираем этот знак для подсчета
        if value[-1] in "-+/*":
            value = value[:-1]
        
        # eval() — встроенная функция Python, которая решает математику из строки (например, "2+2")
        result = eval(value)
        
        # Округляем результат до 10 знаков, чтобы не было длинных хвостов (0.333333333333)
        if isinstance(result, float):
            result = round(result, 10)
            
        calculator.delete(0, tk.END)
        calculator.insert(0, str(result))
    except ZeroDivisionError:
        messagebox.showerror("Ошибка", "Деление на ноль!")
        clear()
    except Exception:
        messagebox.showerror("Ошибка", "Некорректное выражение!")
        clear()

# Квадратный корень
def add_sqrt():
    value = calculator.get()
    try:
        result = math.sqrt(float(value))
        calculator.delete(0, tk.END)
        calculator.insert(0, str(result))
    except ValueError:
        messagebox.showerror("Ошибка", "Нельзя взять корень из отрицательного числа!")
        clear()

# Синус (в радианах)
def add_sin():
    value = calculator.get()
    try:
        # В Python math.sin работает с радианами. Для градусов нужно math.radians(float(value))
        result = math.sin(float(value))
        calculator.delete(0, tk.END)
        calculator.insert(0, str(result))
    except ValueError:
        messagebox.showerror("Ошибка", "Некорректное число")
        clear()

# Косинус (в радианах)
def add_cos():
    value = calculator.get()
    try:
        result = math.cos(float(value))
        calculator.delete(0, tk.END)
        calculator.insert(0, str(result))
    except ValueError:
        messagebox.showerror("Ошибка", "Некорректное число")
        clear()


# 5. СОЗДАНИЕ КНОПОК
# Вместо 10 разных функций make_... мы создаем одну умную функцию, которая делает кнопку
def create_button(text, row, col, command, bg_color="#ffffff"):
    btn = tk.Button(
        tk_root, 
        text=text, 
        width=4, 
        height=2, 
        bd=5, 
        font=('Times New Roman', 13), 
        command=command,
        bg=bg_color
    )
    btn.grid(row=row, column=col, padx=3, pady=3, sticky="nsew")

# 6. РАССТАНОВКА КНОПОК НА СЕТКЕ
# Функции, цифры и знаки
create_button('C', 2, 1, clear, "#ff7f7f")       # Красная кнопка очистки
create_button('<', 2, 2, backspace, "#d9d9d9")    # Удалить символ
create_button('/', 2, 3, lambda: add_operations('/'), "#d9d9d9")
create_button('*', 2, 4, lambda: add_operations('*'), "#d9d9d9")

create_button('7', 3, 1, lambda: add_digit_buttons('7'))
create_button('8', 3, 2, lambda: add_digit_buttons('8'))
create_button('9', 3, 3, lambda: add_digit_buttons('9'))
create_button('-', 3, 4, lambda: add_operations('-'), "#d9d9d9")

create_button('4', 4, 1, lambda: add_digit_buttons('4'))
create_button('5', 4, 2, lambda: add_digit_buttons('5'))
create_button('6', 4, 3, lambda: add_digit_buttons('6'))
create_button('+', 4, 4, lambda: add_operations('+'), "#d9d9d9")

create_button('1', 5, 1, lambda: add_digit_buttons('1'))
create_button('2', 5, 2, lambda: add_digit_buttons('2'))
create_button('3', 5, 3, lambda: add_digit_buttons('3'))
create_button('=', 5, 4, calculate, "#7fff7f")   # Зеленая кнопка равно

create_button('0', 6, 1, lambda: add_digit_buttons('0'))
create_button('.', 6, 2, lambda: add_digit_buttons('.'))

# Научные кнопки (в 7 и 8 ряду)
create_button('√', 7, 1, add_sqrt, "#d9d9d9")
create_button('sin', 7, 2, add_sin, "#d9d9d9")
create_button('cos', 7, 3, add_cos, "#d9d9d9")


# 7. ЗАПУСК ГЛАВНОГО ЦИКЛА
tk_root.mainloop()
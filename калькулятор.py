import tkinter as tk
from tkinter import messagebox
import math

# 1. Создаем окно
root = tk.Tk()
root.title("Калькулятор для отчета")
root.geometry("360x520")
root.resizable(False, False)

# 2. Создаем поле ввода
entry = tk.Entry(root, justify="right", font=("Times New Roman", 20), bd=10, bg="white")
entry.insert(0, "0")
entry.pack(fill=tk.X, padx=10, pady=10)

# 3. Фрейм для кнопок (чтобы сетка не ломалась)
frame = tk.Frame(root)
frame.pack()

# 4. Главная логика калькулятора
def click(char):
    current = entry.get()
    
    # Очистка
    if char == "C":
        entry.delete(0, tk.END)
        entry.insert(0, "0")
    
    # Удаление последнего символа
    elif char == "<":
        if len(current) > 1:
            entry.delete(len(current)-1, tk.END)
        else:
            entry.delete(0, tk.END)
            entry.insert(0, "0")
            
    # Подсчет результата
    elif char == "=":
        try:
            # Если в конце висит знак, убираем его
            if current[-1] in "+-*/":
                current = current[:-1]
            result = eval(current)
            entry.delete(0, tk.END)
            entry.insert(0, str(result))
        except ZeroDivisionError:
            messagebox.showerror("Ошибка", "На ноль делить нельзя!")
            entry.delete(0, tk.END)
            entry.insert(0, "0")
        except:
            messagebox.showerror("Ошибка", "Неверное выражение!")
            entry.delete(0, tk.END)
            entry.insert(0, "0")
            
    # Синус, косинус, корень
    elif char in ["sin", "cos", "√"]:
        try:
            num = float(current)
            if char == "sin":
                result = math.sin(num)
            elif char == "cos":
                result = math.cos(num)
            elif char == "√":
                result = math.sqrt(num)
            result = round(result, 8) # Округляем до 8 знаков
            entry.delete(0, tk.END)
            entry.insert(0, str(result))
        except:
            messagebox.showerror("Ошибка", "Некорректное число!")
            entry.delete(0, tk.END)
            entry.insert(0, "0")
            
    # Ввод цифр и знаков
    else:
        # Если на экране "0", стираем его перед вводом цифры
        if current == "0" and char not in [".", "+", "-", "*", "/"]:
            entry.delete(0, tk.END)
            entry.insert(0, char)
        else:
            # Не даем ввести два знака подряд
            if current and current[-1] in "+-*/" and char in "+-*/":
                entry.delete(len(current)-1, tk.END)
                entry.insert(tk.END, char)
            else:
                entry.insert(tk.END, char)

# 5. Функция создания кнопки
def make_button(text, row, col, color="#ffffff"):
    btn = tk.Button(frame, text=text, font=("Times New Roman", 14), bg=color, width=4, height=2,
                    command=lambda: click(text))
    btn.grid(row=row, column=col, padx=3, pady=3)

# 6. Рисуем кнопки (все на своих местах)
# Ряд 1
make_button("C", 0, 0, "#ff9999")
make_button("(", 0, 1, "#e0e0e0")
make_button(")", 0, 2, "#e0e0e0")
make_button("√", 0, 3, "#cce5ff")
make_button("/", 0, 4, "#e0e0e0")

# Ряд 2
make_button("7", 1, 0)
make_button("8", 1, 1)
make_button("9", 1, 2)
make_button("sin", 1, 3, "#cce5ff")
make_button("*", 1, 4, "#e0e0e0")

# Ряд 3
make_button("4", 2, 0)
make_button("5", 2, 1)
make_button("6", 2, 2)
make_button("cos", 2, 3, "#cce5ff")
make_button("-", 2, 4, "#e0e0e0")

# Ряд 4
make_button("1", 3, 0)
make_button("2", 3, 1)
make_button("3", 3, 2)
make_button("<", 3, 3, "#e0e0e0")
make_button("+", 3, 4, "#e0e0e0")

# Ряд 5
make_button("0", 4, 0)
make_button(".", 4, 1)
# Кнопку "=" растягиваем
btn_eq = tk.Button(frame, text="=", font=("Times New Roman", 14), bg="#99ff99", width=4, height=2,
                   command=lambda: click("="))
btn_eq.grid(row=4, column=2, columnspan=3, padx=3, pady=3, sticky="nsew")

root.mainloop()
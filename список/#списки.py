#списки
list = [5,3,8,9,"привет",4.2] #сам список
print(list[2]) #выодим элемент под номером два в списке
print(list[2]+list[0]) #сложение элементов списка

#выод всех элементов списка
for item in list:
    print (item)
#выод ээлементов по индексу
for index,item in enumerate(list):
    print(f"индекс: {index}, элемент: {item}")
    
for index in range(len(list)-1):
    print(list[index])
    
    
#сумма всех чисел
list = [5,10,30,20,40]
s = 0
for num in list:
    s+=num

#поиск четных чисел вывезти на экран только четные
##list = [3,2,1,4,5,10]
##for n in list:
    ##if list[n] %2 ==0 :
     ##print[n]
    ##else:
        ##print("число нечетное")
        
        
        
#изменение списка
list_student = ["александр","майкл","рома","дэвид"]
print(list_student)
while True:
    Choice = int(input("1 добавить в список студента"))
    print("2-убрать студента по номеру в списке\n",
        "3-убрать студента по имени в списке",
        "0-выйти из программы")
    
    if Choice not in [0,1,2,3]:
     continue
    elif Choice == 1:
     student = input("введите имя студента: ")
     list_student.append(student)
     print(list_student)
    elif Choice == 2:
      student_delenie = int(input("введите номер студента в списке: "))
      list_student.pop(student_delenie)
      print(list)
    elif Choice == 3:
      student_delenie_2 = input("введите имя студентв в списке: ")
      list_student.remove(student_delenie_2)
      print(list_student)
    elif Choice == 0:
       break
      
#особые методы

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
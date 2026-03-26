# Импортируем аннотации типов для использования их в классах
from __future__ import annotations
# Импортируем декораторы для создания классов данных
from dataclasses import dataclass, field, asdict

# Импортируем типы для аннотаций (списки, опциональные значения, словари)
from typing import List, Optional, Dict, Any

# Импортируем класс для создания перечислений (enum)
from enum import Enum

# Импортируем модуль для работы с JSON файлами
import json

# Импортируем класс для работы с датой и временем
from datetime import datetime

# Создаем перечисление для классов персонажей
class CharacterClass(Enum):
  #Войн - значение "warioir"
  WARRIOR = "warrior"
  #Маг - значение "маг"
  MAGE = "mage";
  #Лучник - значение "лучник"
  ARCHER = "archer"
# Создаем перечесление для классов оружия
class EquipmemntSlot(Enum):
#слот для оружия
WEAPON ="weapon"
ARMOR = "armor"
ACCESSORY = "accesory"
#декоратор @dataclass автоматически создает методы _init_,_repr_,_eq_
@dateclass
class Equipment:
 #атрибут имя предмета(строка)
 name: str
 #атрибут: характеристики (тип equipmentSlot)
 # field(default_factory=dict) создает новый dict для каждого экземпляра
 stats: Dict[str, int] = field(default_factory=dict)
 # Атрибут: редкость предмета (строка, по умолчанию "common")
 rarity: str = "common"
# Метод для преобразования объекта в словарь (для JSON сериализации)
    def to_dict(self) -> Dict[str, Any]:
        # Возвращаем словарь со всеми полями предмета
        return {
            # Ключ 'name' = значение self.name
            'name': self.name,
            # Ключ 'slot' = значение слота (через .value получаем строку)
            'slot': self.slot.value,
            # Ключ 'stats' = словарь характеристик
            'stats': self.stats,
            # Ключ 'rarity' = редкость предмета
            'rarity': self.rarity
        }


# Класс-метод для создания объекта из словаря (для JSON десериализации)
# @classmethod означает что метод принадлежит классу, а не экземпляру
@classmethod
def from_dict(cls, data: Dict[str, Any]) -> Equipment:
# Возвращаем новый объект Equipment, созданный из данных словаря
return cls(
    # Берем имя из словаря data по ключу 'name'
    name=data['name'],
    # Создаем EquipmentSlot из строки в словаре
    slot=EquipmentSlot(data['slot']),
    # Берем характеристики или пустой словарь если их нет
    stats=data.get('stats', {}),
    # Берем редкость или "common" по умолчанию
    rarity=data.get('rarity', 'common')
)
# Декоратор @dataclass для автоматического создания методов
@dataclass
class Skill:
    # Атрибут: название навыка (строка, обязательный)
    name: str
    # Атрибут: описание навыка (строка, обязательный)
    description: str
    # Атрибут: текущий уровень навыка (целое число, по умолчанию 1)
    level: int = 1
    # Атрибут: максимальный уровень навыка (целое число, по умолчанию 10)
    max_level: int = 10

    # Метод для преобразования объекта в словарь
    def to_dict(self) -> Dict[str, Any]:
        # asdict автоматически преобразует все поля dataclass в словарь
        return asdict(self)

    # Класс-метод для создания объекта из словаря
    @classmethod
    def from_dict(cls, data: Dict[str, Any]) -> Skill:
        # **data распаковывает словарь в именованные аргументы
        # Эквивалентно: cls(name=data['name'], description=data['description'], ...)
        return cls(**data)
# Декоратор @dataclass для автоматического создания методов
@dataclass
class Character:
    # Атрибут: имя персонажа (строка, обязательный)
    name: str
    # Атрибут: класс персонажа (тип CharacterClass, обязательный)
    character_class: CharacterClass
    # Атрибут: характеристика силы (целое число, по умолчанию 0)
    strength: int = 0
    # Атрибут: характеристика ловкости (целое число, по умолчанию 0)
    agility: int = 0
    # Атрибут: характеристика интеллекта (целое число, по умолчанию 0)
    intelligence: int = 0
    # Атрибут: словарь экипировки (ключ=слот, значение=предмет)
    # default_factory=dict создает новый dict для каждого экземпляра
    equipment: Dict[EquipmentSlot, Equipment] = field(default_factory=dict)
    # Атрибут: список навыков персонажа
    # default_factory=list создает новый list для каждого экземпляра
    skills: List[Skill] = field(default_factory=list)
    # Атрибут: текущий уровень персонажа (целое число, по умолчанию 1)
    level: int = 1
    # Атрибут: текущий опыт персонажа (целое число, по умолчанию 0)
    experience: int = 0
    # Атрибут: максимальный опыт для следующего уровня (целое число, по умолчанию 100)
    max_experience: int = 100
    # Атрибут: количество золота (целое число, по умолчанию 0)
    gold: int = 0
    # Атрибут: дата создания персонажа (строка ISO формата)
    # lambda создает функцию которая вызывается при создании каждого объекта
    created_at: str = field(default_factory=lambda: datetime.now().isoformat())

    # Константа класса: максимальная сумма всех характеристик
    MAX_TOTAL_STATS = 50
    # Константа класса: множитель опыта для каждого уровня
    XP_MULTIPLIER = 1.5
    # Приватный метод для валидации характеристик (начинается с _)
    def _validate_stats(self) -> None:
        # Вычисляем общую сумму всех трех характеристик
        total = self.strength + self.agility + self.intelligence
        # Проверяем не превышает ли сумма максимальное значение
        if total > self.MAX_TOTAL_STATS:
            # Если превышает - выбрасываем исключение с сообщением об ошибке
            raise ValueError(f"Сумма характеристик ({total}) не может превышать {self.MAX_TOTAL_STATS}")
    # Метод для добавления опыта персонажу
    # Возвращает True если уровень повышен, False если нет
    def add_experience(self, xp: int) -> bool:
        # Добавляем полученный опыт к текущему опыту
        self.experience += xp
        # Флаг для отслеживания повышения уровня (по умолчанию False)
        leveled_up = False
        # Цикл while: пока опыт больше или равен максимальному
        while self.experience >= self.max_experience:
            # Вычитаем максимальный опыт из текущего (переносим излишек)
            self.experience -= self.max_experience
            # Увеличиваем уровень персонажа на 1
            self.level += 1
            # Увеличиваем максимальный опыт для следующего уровня (умножаем на множитель)
            # int() округляет до целого числа
            self.max_experience = int(self.max_experience * self.XP_MULTIPLIER)
            # Устанавливаем флаг что уровень был повышен
            leveled_up = True
        # Возвращаем флаг повышения уровня
        return leveled_up

    # Метод для добавления навыка персонажу
    def add_skill(self, skill: Skill) -> None:
        # Проходим циклом по всем существующим навыкам персонажа
        for existing in self.skills:
            # Проверяем есть ли навык с таким же названием
            if existing.name == skill.name:
                # Если есть - увеличиваем уровень существующего навыка
                # min() выбирает меньшее значение (чтобы не превысить max_level)
                existing.level = min(existing.level + 1, existing.max_level)
                # Выходим из метода (return без значения)
                return
        # Если навыка не было в списке - добавляем новый навык
        self.skills.append(skill)

    # Метод для экипировки предмета
    def equip_item(self, equipment: Equipment) -> None:
        # Добавляем предмет в словарь экипировки
        # Ключ = слот предмета, Значение = сам предмет
        self.equipment[equipment.slot] = equipment

    # Метод для получения итоговых характеристик (с учетом экипировки)
    def get_total_stats(self) -> Dict[str, int]:
        # Создаем словарь с базовыми характеристиками персонажа
        base_stats = {
            # Ключ 'strength' = значение силы персонажа
            'strength': self.strength,
            # Ключ 'agility' = значение ловкости персонажа
            'agility': self.agility,
            # Ключ 'intelligence' = значение интеллекта персонажа
            'intelligence': self.intelligence
        }
        # Проходим циклом по всем предметам экипировки
        for item in self.equipment.values():
            # Проходим циклом по всем характеристикам предмета
            for stat, value in item.stats.items():
                # Проверяем есть ли такая характеристика в base_stats
                if stat in base_stats:
                    # Добавляем бонус от предмета к характеристике
                    base_stats[stat] += value
        # Возвращаем словарь с итоговыми характеристиками
        return base_stats

    # Метод для вычисления общего уровня силы персонажа
    def get_power_level(self) -> int:
        # Получаем итоговые характеристики (с учетом экипировки)
        stats = self.get_total_stats()
        # Вычисляем бонус от всей экипировки
        # sum() суммирует все значения, вложенный sum() суммирует характеристики каждого предмета
        equipment_bonus = sum(sum(item.stats.values()) for item in self.equipment.values())
        # Вычисляем бонус от навыков (каждый уровень навыка дает +5 к силе)
        skill_bonus = sum(skill.level * 5 for skill in self.skills)
        # Возвращаем общую сумму: характеристики + экипировка + навыки + бонус за уровень
        return sum(stats.values()) + equipment_bonus + skill_bonus + self.level * 10
    # Метод для преобразования персонажа в словарь (для JSON)
    def to_dict(self) -> Dict[str, Any]:
        # Возвращаем словарь со всеми полями персонажа
        return {
            # Ключ 'name' = имя персонажа
            'name': self.name,
            # Ключ 'character_class' = значение класса (строка через .value)
            'character_class': self.character_class.value,
            # Ключ 'strength' = сила
            'strength': self.strength,
            # Ключ 'agility' = ловкость
            'agility': self.agility,
            # Ключ 'intelligence' = интеллект
            'intelligence': self.intelligence,
            # Ключ 'equipment' = словарь экипировки (преобразуем каждый предмет через to_dict())
            'equipment': {slot.value: item.to_dict() for slot, item in self.equipment.items()},
            # Ключ 'skills' = список навыков (преобразуем каждый навык через to_dict())
            'skills': [skill.to_dict() for skill in self.skills],
            # Ключ 'level' = уровень персонажа
            'level': self.level,
            # Ключ 'experience' = текущий опыт
            'experience': self.experience,
            # Ключ 'max_experience' = максимальный опыт
            'max_experience': self.max_experience,
            # Ключ 'gold' = золото
            'gold': self.gold,
            # Ключ 'created_at' = дата создания
            'created_at': self.created_at
        }
    # Метод для сохранения персонажа в JSON файл
    def to_json(self, filepath: str) -> None:
        # Открываем файл для записи ('w'), с кодировкой UTF-8
        # 'as f' означает что файл будет доступен через переменную f
        with open(filepath, 'w', encoding='utf-8') as f:
            # json.dump() записывает объект в файл
            # self.to_dict() преобразует персонажа в словарь
            # indent=2 делает красивое форматирование с отступами
            # ensure_ascii=False позволяет сохранять кириллицу без кодирования
            json.dump(self.to_dict(), f, indent=2, ensure_ascii=False)
        # Выводим сообщение об успешном сохранении
        print(f"Персонаж сохранен в {filepath}")

    # Класс-метод для создания персонажа из словаря
    @classmethod
    def from_dict(cls, data: Dict[str, Any]) -> Character:
        # Возвращаем новый объект Character из данных словаря
        return cls(
            # Берем имя из словаря
            name=data['name'],
            # Создаем CharacterClass из строки в словаре
            character_class=CharacterClass(data['character_class']),
            # Берем силу из словаря
            strength=data['strength'],
            # Берем ловкость из словаря
            agility=data['agility'],

            # Берем интеллект из словаря
            intelligence=data['intelligence'],
            # Преобразуем словарь экипировки в объекты Equipment
            # Для каждого slot и item создаем Equipment из словаря
            equipment={
                EquipmentSlot(slot): Equipment.from_dict(item)
                for slot, item in data.get('equipment', {}).items()
            },
            # Преобразуем список навыков в объекты Skill
            skills=[Skill.from_dict(s) for s in data.get('skills', [])],
            # Берем уровень или 1 по умолчанию
            level=data.get('level', 1),
            # Берем опыт или 0 по умолчанию
            experience=data.get('experience', 0),
            # Берем максимальный опыт или 100 по умолчанию
            max_experience=data.get('max_experience', 100),
            # Берем золото или 0 по умолчанию
            gold=data.get('gold', 0),
            # Берем дату создания или текущее время по умолчанию
            created_at=data.get('created_at', datetime.now().isoformat())
        )
    # Класс-метод для загрузки персонажа из JSON файла
    @classmethod
    def from_json(cls, filepath: str) -> Character:
        # Открываем файл для чтения ('r') с кодировкой UTF-8
        with open(filepath, 'r', encoding='utf-8') as f:
            # json.load() читает данные из файла в словарь
            data = json.load(f)
        # Выводим сообщение об успешной загрузке
        print(f"Персонаж загружен из {filepath}")
        # Вызываем from_dict() для создания объекта из прочитанных данных
        return cls.from_dict(data)
    # Метод __str__ вызывается когда печатаем объект через print()
    def __str__(self) -> str:
        # Получаем итоговые характеристики (с экипировкой)
        stats = self.get_total_stats()
        # Возвращаем форматированную строку с информацией о персонаже
        # f""" """ позволяет использовать многострочный текст с подстановкой переменных
        # {variable} вставляет значение переменной в строку
        return f"""
{'=' * 50}
{self.name} - {self.character_class.value}
Уровень: {self.level}
Опыт: {self.experience}/{self.max_experience}
Характеристики:
  Сила: {stats['strength']}
  Ловкость: {stats['agility']}
  Интеллект: {stats['intelligence']}
Уровень силы: {self.get_power_level()}
Навыков: {len(self.skills)}
Золота: {self.gold}
{'=' * 50}
"""
class CharacterBuilder:
    # Метод __init__ вызывается при создании нового объекта Builder
    def __init__(self):
        # Вызываем метод reset() для инициализации builder
        self.reset()

    # Метод для сброса builder к начальному состоянию
    # Возвращает self для поддержки цепочки вызовов (fluent interface)
    def reset(self) -> CharacterBuilder:
        # Создаем нового персонажа с значениями по умолчанию
        self._character = Character(name="Unnamed", character_class=CharacterClass.WARRIOR)
        # Возвращаем self чтобы можно было продолжать цепочку вызовов
        return self

    # Метод для установки имени персонажа
    # Возвращает self для поддержки цепочки вызовов
    def set_name(self, name: str) -> CharacterBuilder:
        # Проверяем что имя не пустое и не состоит только из пробелов
        if not name or len(name.strip()) == 0:
            # Если имя невалидное - выбрасываем исключение
            raise ValueError("Имя не может быть пустым")
        # Устанавливаем имя персонажа (strip() удаляет пробелы по краям)
        self._character.name = name.strip()
        # Возвращаем self для цепочки вызовов
        return self

    # Метод для установки класса персонажа
    def set_class(self, char_class: CharacterClass) -> CharacterBuilder:
        # Устанавливаем класс персонажа
        self._character.character_class = char_class
        # Возвращаем self для цепочки вызовов
        return self

    # Метод для установки всех трех характеристик сразу
    def set_stats(self, strength: int = 0, agility: int = 0, intelligence: int = 0) -> CharacterBuilder:
        # Вычисляем общую сумму характеристик
        total = strength + agility + intelligence
        # Проверяем не превышает ли сумма максимальное значение
        if total > Character.MAX_TOTAL_STATS:
            # Если превышает - выбрасываем исключение
            raise ValueError(f"Сумма характеристик ({total}) не может превышать {Character.MAX_TOTAL_STATS}")
        # Проверяем что ни одна характеристика не отрицательная
        # any() возвращает True если хотя бы одно значение True
        if any(stat < 0 for stat in [strength, agility, intelligence]):
            # Если есть отрицательные - выбрасываем исключение
            raise ValueError("Характеристики не могут быть отрицательными")
        # Устанавливаем силу персонажа
        self._character.strength = strength
        # Устанавливаем ловкость персонажа
        self._character.agility = agility
        # Устанавливаем интеллект персонажа
        self._character.intelligence = intelligence
        # Возвращаем self для цепочки вызовов
        return self

    # Метод для добавления оружия персонажу
    def add_weapon(self, name: str, stats: Dict[str, int] = None, rarity: str = "common") -> CharacterBuilder:
        # Создаем новый объект Equipment для оружия
        # stats or {} означает: если stats=None то используем пустой словарь
        equipment = Equipment(name=name, slot=EquipmentSlot.WEAPON, stats=stats or {}, rarity=rarity)
        # Добавляем предмет в словарь экипировки персонажа
        self._character.equipment[EquipmentSlot.WEAPON] = equipment
        # Возвращаем self для цепочки вызовов
        return self

    # Метод для добавления брони персонажу
    def add_armor(self, name: str, stats: Dict[str, int] = None, rarity: str = "common") -> CharacterBuilder:
        # Создаем новый объект Equipment для брони
        equipment = Equipment(name=name, slot=EquipmentSlot.ARMOR, stats=stats or {}, rarity=rarity)
        # Добавляем предмет в словарь экипировки персонажа
        self._character.equipment[EquipmentSlot.ARMOR] = equipment
        # Возвращаем self для цепочки вызовов
        return self

    # Метод для добавления навыка персонажу
    def add_skill(self, name: str, description: str = "", level: int = 1) -> CharacterBuilder:
        # Создаем новый объект Skill
        skill = Skill(name=name, description=description, level=level)
        # Добавляем навык в список навыков персонажа
        self._character.skills.append(skill)
        # Возвращаем self для цепочки вызовов
        return self

    # Метод для установки уровня персонажа
    def set_level(self, level: int) -> CharacterBuilder:
        # Проверяем что уровень не меньше 1
        if level < 1:
            # Если меньше - выбрасываем исключение
            raise ValueError("Уровень не может быть меньше 1")
        # Устанавливаем уровень персонажа
        self._character.level = level
        # Возвращаем self для цепочки вызовов
        return self

        # Метод для установки количества золота

    def set_gold(self, gold: int) -> CharacterBuilder:
        # Проверяем что золото не отрицательное
        if gold < 0:
            # Если отрицательное - выбрасываем исключение
            raise ValueError("Золото не может быть отрицательным")
        # Устанавливаем количество золота
        self._character.gold = gold
        # Возвращаем self для цепочки вызовов
        return self

        # Метод для завершения построения и получения готового персонажа

    def build(self) -> Character:
        # Сохраняем ссылку на созданного персонажа во временную переменную
        character = self._character
        # Сбрасываем builder для создания следующего персонажа
        self.reset()
        # Возвращаем готового персонажа
        return character

    class CharacterDirector:
        # Метод __init__ для инициализации директора
        def __init__(self, builder: CharacterBuilder):
            # Сохраняем ссылку на builder в приватное поле
            self._builder = builder

        # Метод для создания воина (готовый шаблон)
        def create_warrior(self, name: str = "Воин") -> Character:
            # Возвращаем результат цепочки вызовов builder
            # Каждый метод возвращает builder, поэтому можно вызывать по цепочке
            return (self._builder
                    # Устанавливаем имя персонажа
                    .set_name(name)
                    # Устанавливаем класс - ВОИН
                    .set_class(CharacterClass.WARRIOR)
                    # Устанавливаем характеристики (сила 25, ловкость 10, интеллект 5)
                    .set_stats(strength=25, agility=10, intelligence=5)
                    # Добавляем оружие с бонусом к силе
                    .add_weapon("Меч правосудия", {'strength': 10}, "epic")
                    # Добавляем броню с бонусом к силе
                    .add_armor("Латы титана", {'strength': 5}, "legendary")
                    # Добавляем первый навык
                    .add_skill("Мощный удар", "Наносит 150% урона", 5)
                    # Добавляем второй навык
                    .add_skill("Боевой клич", "Увеличивает силу на 20%", 3)
                    # Устанавливаем уровень 10
                    .set_level(10)
                    # Устанавливаем золото 500
                    .set_gold(500)
                    # Завершаем построение и получаем готового персонажа
                    .build())

        # Метод для создания мага (готовый шаблон)
        def create_mage(self, name: str = "Маг") -> Character:
            # Возвращаем результат цепочки вызовов builder
            return (self._builder
                    # Устанавливаем имя персонажа
                    .set_name(name)
                    # Устанавливаем класс - МАГ
                    .set_class(CharacterClass.MAGE)
                # Устанавливаем характеристики (интеллект 25 - главный стат мага)
                .set_stats(strength=5, agility=10, intelligence=25)
                # Добавляем оружие с бонусом к интеллекту
                .add_weapon("Посох древних", {'intelligence': 15}, "legendary")
                # Добавляем броню с бонусом к интеллекту
                .add_armor("Мантия архимага", {'intelligence': 10}, "epic")
                # Добавляем первый навык
                .add_skill("Огненный шар", "Наносит урон огнем", 7)
                # Добавляем второй навык
                .add_skill("Ледяная стрела", "Замораживает врага", 5)
                # Устанавливаем уровень 12
                .set_level(12)
                # Устанавливаем золото 750
                .set_gold(750)
                # Завершаем построение
                .build())

    # Метод для создания лучника (готовый шаблон)
    def create_archer(self, name: str = "Лучник") -> Character:
        # Возвращаем результат цепочки вызовов builder
        return (self._builder
                # Устанавливаем имя персонажа
                .set_name(name)
                # Устанавливаем класс - ЛУЧНИК
                .set_class(CharacterClass.ARCHER)
                # Устанавливаем характеристики (ловкость 25 - главный стат лучника)
                .set_stats(strength=10, agility=25, intelligence=5)
                # Добавляем оружие с бонусом к ловкости
                .add_weapon("Лук теней", {'agility': 12}, "legendary")
                # Добавляем броню с бонусом к ловкости
                .add_armor("Кожаная броня", {'agility': 8}, "epic")
                # Добавляем первый навык
                .add_skill("Точный выстрел", "Гарантированный крит", 6)
                # Добавляем второй навык
                .add_skill("Двойной выстрел", "Две стрелы сразу", 4)
                # Устанавливаем уровень 11
                .set_level(11)
                # Устанавливаем золото 600
                .set_gold(600)
                # Завершаем построение
                .build())

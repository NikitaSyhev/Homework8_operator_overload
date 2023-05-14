# Homework8_operator_overload

Аудиторное задание.
Изменить код определения операции сравнения так, чтобы выполнялись нижеперечисленные условия.

1. Монеты равны, но доблесть первого игрока уступает доблести второго => успешней 2-ой игрок
2. Доблесть равна, но монеты первого игрока уступает монетам второго => успешней 2-ой игрок
3. Монеты первого игрока уступает монетам второго, но доблесть первого игрока выше доблести второго => успешней 1-й игрок

Монеты и доблесть назначается через рандомизатор.

Домашнее задание (см. приложенный исходный код):
1. Вынести класс Gamers в отдельный файл.
2. Добавить параметр "везучесть" (определяется случайным образом).
3. Сформировать метод набора до 8 игроков
4. Создать метод, объединяющий игроков в команды. При объединении формируется имя команды, складываются монеты и доблесть, перемножается везучесть.
5. Программа должна сэмулировать столкновение 2-х команд и сравнить их суммарные параметры. При прочих равных сравнивается везучесть.

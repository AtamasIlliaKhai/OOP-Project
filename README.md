Опис предметної області
Короткий опис:
Бібліотека — це заклад, який забезпечує доступ до книжок, журналів, електронних матеріалів та інших ресурсів. У системі бібліотеки можна виділити основні елементи: книги, читачі, бібліотекарі, каталоги, бронювання та позичення книжок.
Основні класи:
1.	Бібліотека (Library) — головний клас, що представляє бібліотеку.
2.	Книга (Book) — об’єкт, який може бути в наявності у бібліотеці.
3.	Читач (Reader) — користувач, який має доступ до бібліотеки.
4.	Бібліотекар (Librarian) — працівник, який керує діяльністю бібліотеки.
5.	Каталог (Catalog) — система для організації книжок.
6.	Бронювання (Reservation) — процес резервування книги.
7.	Позичення (Loan) — процес видачі книги читачу.
Типи відношень:
•	Асоціація: Читач пов’язаний з бронюванням і позиченням.
•	Агрегація: Бібліотека містить каталог, який складається з багатьох книг.
•	Композиція: Позичення повністю залежить від читача та книги, без яких воно не існує.
•	Реалізація: Інтерфейси для базових операцій, наприклад, управління каталогом чи записами бронювань.
 ![image](https://github.com/user-attachments/assets/ad2c314a-c15e-4cd3-b196-f96960fa8c97)

Рисунок 1 – UML діаграма класів. Елементи предметної області та зв’язки між ними

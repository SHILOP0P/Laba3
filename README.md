# Laba3
## Описание  
Проект реализует CRUD операции для трёх связанных сущностей:

- **Director** — режиссёр, владелец одного или нескольких фильмов (связь один ко многим).  
- **Movie** — фильм, связанный с режиссёром и актёрами (многие ко многим с актёрами через MovieActor).  
- **Actor** — актёр, участвующий в одном или нескольких фильмах (связь многие ко многим через MovieActor).  
- **MovieActor** — связующая таблица для many-to-many между фильмами и актёрами.

---

## Структура проекта  
- **Controllers/** — контроллеры для API (Directors, Movies, Actors, MovieActors)  
- **Models/** — модели данных (Director, Movie, Actor, MovieActor)  
- **Data/MovieContext.cs** — контекст базы данных Entity Framework Core  
- **Program.cs** — точка входа и конфигурация приложения  

---

## Скриншоты таблиц  
## Таблица с фильмами
![image](https://github.com/user-attachments/assets/2ad7e6dc-9239-448a-b0c6-389f71659d74)
## Таблица с режиссерами
![image](https://github.com/user-attachments/assets/0269282d-62c7-4618-840c-12fea10aeef5)
## Таблица с актерами
![image](https://github.com/user-attachments/assets/e10c7b08-e6b3-4c75-8e8f-c13dacc2261b)
## Таблица связей актеров и фильмов
![image](https://github.com/user-attachments/assets/61face0a-3fd6-4b72-965e-388ea577f3b5)







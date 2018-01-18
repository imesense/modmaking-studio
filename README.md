# Об Octagon Modmaking Studio

Octagon Modmaking Studio - программный комплекс, предназначенный для упрощённого создания модификаций для игры S.T.A.L.K.E.R.: Call of Pripyat, а также для модификации S.T.A.L.K.E.R.: Call of Chernobyl. На данный момент комплекс находится в начальной стадии разработки.

Скачать релиз-версию можно будет на [сайте ImeSense](http://imesense.ru/octagon/).
Документация будет распологаться [здесь](http://imesense.ru/octagon_docs/).

# Текущая версия

Octagon Modmaking Studio Mk 0 (pre-alpha)

# Модули OMS

Помимо главного окна, программный комплекс будет состоять из модулей, каждый из который выполняет свою узкую область функций:

- **Changes Manager**: модуль, контролирующий и фиксирующий изменения в модификации, планируется его интеграция с API GitHub.
- **Редактирование параметров модификации**.
- **Project Manager**: каждая модификация во время разработки будет представлять собой проект.
- **Platform Manager**: в проекте модификации также обязательно наличие тестовой платформы для запуска и тестирования билдов модификации.
- **Component Manager**: некоторые изменения игры в модификацию можно "подключать" посредством использования компонентов, которые создаются отдельно.
- **Notes**: возможность ведения заметок для себя в программном комплексе, а также в самом проекте для других разработчиков проекта.
- **Backup Manager**: возможность создания бэкапов модификации, восстановления модификации до определённого состояния с помощью них.
- **Build Manager**: модуль, предназначенный для сборки файлов Octagon Modmaking Studio в рабочий вариант модификации, запуска модификации на тестовой или релизной версии платформы. Также данный модуль должен позволять пользователю запускать билд на определённой локации или на тестовой локации, которая включается в Octagon Modmaking Studio.
- **Equipment Editor)**: редактор всего снаряжения и используемых предметов в игре, кроме костюмов и вооружения.
- **Clothes Editor**: редактор костю+мов и комбинезонов и их веток улучшения.
- **Weapon Editor**: редактор вооружения в игре.
- **Clans Editor**: редактор, позволяющий управлять группировками в игре.
- **Artefacts Editor**: редактор для создания, редактирования и удаления артефактов в игре.
- **Anomalies Editor**: редактор для изменения конфигурации и спауна аномалий.
- **Locations Manager**: редактор, позволяющий подключать и отключать локации к модификации. 
- **HUD Editor**: редактор, позволяющий удобно редактировать положение и наличие компонентов HUD.
- **A-Life Editor**: редактор, позволяющий удобно изменять конфигурацию симуляции жизни в игре.
- **Quest Editor**: редактор квестов.
- **Converter Manager**: модуль с графическом редактором, позволяющий конвертировать некоторые файлы в форматы, понятные игре, и наоборот.
- **Unit Editor**: редактор NPC и сквадов.
- **Trade Editor**: редактор торговцев и их ассортимента.
- **Weather Editor**: редактор конфигурации и пресетов погоды.
- **Logs Analyzer**: анализатор логов при вылетах игры.

# Планируемая функциональность

Ниже будут описаны все функции, наличие которых запланировано в программном комплексе. Галочкой  &#10003; будут помечены те функции, которые уже реализованы. Жирным восклицательным знаком **!** будут отмечены те функции, которые обязательно должны присутствовать в первой релизной версии (Mk 1).

- Модуль "Project Manager":
  - создание проекта **!** &#10003;
  - сохранение проекта **!**
  - возможность загрузки десятпи последних открытых проектов или компонентов
  - автозагрузка последнего проекта
  - сохранение проекта в новую директорию **!**
  - автосохранение проекта для предотвращения потери данных
  - открытие проекта **!**
  - закрытие проекта (выход на стартовый экран) **!**
  - сравнение проекта с другим для анализа различий и для возможности их последующего слияния **!**
- Модуль "Platform Manager":
  - копирование платформы игры при создании проекта или при выборе пользователя в папку проекта **!**
  - возможность подключения пользовательских платформ **!**
- Настройка интерфейса:
  - изменение языка пользовательского интерфейса **!** &#10003;
  - возможность создания и подлкючения новых языковых интерфейсов **!** &#10003;
  - изменение цветовой темы оформления интерфейса 
  - возможность создания цветовых тем оформления интерфейса
  - сохранение положения и размеров главного окна для загрузки этих параметров при следующем открытии программы **!**
  - сортировка кнопок модулей программного комплекса в левой части **!**
  - настройка отображения встроенных окон в рабочей области главного окна **!**
- Модуль "Component Manager":
  - выделение некоторых изменений модификации в компоненты
  - экспорт компонентов
  - импорт компонентов с проверкой на конфликтность с текущими изменениями проекта
  - вывод списка всех компонентов в текущем проекте
  - выделение свойств компонента
  - редактирование свойств компонента
- Модуль "Changes Manager":
  - отслеживание изменений с использованием API git **!**
  - загрузка проекта на GitHub в виде репозитория **!**
  - просмотр истории изменений **!**
- Наличие текстового редактора:
  - редактирование текстовых файлов любых форматов **!**
  - редактирование файлов формата XML, LTX и SCRIPT с соответствующей подсветкой синтаксиса **!**
  - поиск и замена участков текста **!**
  - автозакрытие тегов в XML **!**
  - автодобавление правых кавычек, обычных, квадратных и фигурных скобок при вводе левой **!**
  - замена табуляций на пробелы **!**
  - регулирование количества пробелов в табуляциии
  - подсказки при вводе
  - разметка свойств со значениями в LTX файлах **!**
- Модуль "Notes":
  - создание, редактирование и удаление заметок в программе
  - создание, редактирование и удаление заметок в проекте
- Модуль "Backup Manager":
  - создание бэкапа
  - восстановление проекта из бэкапа
  - просмотр всех бэкапов проекта
- Модуль "Build Manager":
  - сборка билда для отладки **!**
  - сборка релиз-билда **!**
  - запуск билда для отладки на одном из игровых уровней **!**
  - запуск билда для отладки на тестовом уровне **!**
  - запуск релиз-билда на одном из игровых уровней **!**
  - запуск релиз-билда с новой игрой 
  - запуск релиз-билда с определённого сохранения
  - сборка патча **!**
  - сборка патча и экспорт для публикации в сети **!**
- Модуль "Equipment Editor":
  - создание элементов снаряжения следующих категорий: еда, медикаменты, квестовые предметы и пр.
  - создание элементов снаряжения с использованием конфигурации уже имеющегося элемента
  - изменение созданных элементов снаряжения
  - удаление элементов снаряжения
  - изменение параметров бинокля
  - изменение параметров болтов
- Модуль "Weapon Editor":
  - создание единиц вооружения следующих типов: пистолет, пистолет-пулемёт, автоматическая винтовка, снайперская винтовка, гранатомёт и пр.
  - возможность создания нового типа оружия
  - изменение созданных единиц вооружения
  - удаление единиц вооружения
  - создание, изменение и удаление веток улучшения оружия
  - создание, изменение и удаление аддонов для оружия
  - создание, изменение и удаление боеприпасов
  - создание, изменение и удаление гранат
  - изменение параметров холодного оружия
- Модуль "Clans Editor":
  - создание, изменение и удаление группировок
  - настройка отношений между группировками  
- Модуль "Artefacts Editor":
  - создание, изменение и удаление артефактов
  - изменение вероятности выпадения артефакта в аномалиях
- Модуль "Anomalies Editor":
  - создание, изменение и удаление аномалий
  - изменение партиклей аномалий
- Модуль "Locations Manager":
  - подключение и отключение локаций
  - редактирование конфигурации локации
  - редактирование глобальной карты игры в визуальном редакторе
  - соединение локаций между собой
- Модуль "HUD Edtior":
  - подключение и отключение компонентов HUD
  - редактирование положения компонентов HUD
  - редактирование параметров компонентов HUD
- Модуль "A-Life Editor":
  - изменение поведения искусственного интеллекта
  - редактирование онлайн- и оффлайн-зон поведения NPC
- Модуль "Quest Editor":
  - добавление и удаление квестов в визуальном редакторе
  - редактирование квестов в визуальном редакторе
  - загрузка примеров квестов
- Модуль "Converter Manager":
  - распаковка и запаковка игровых ресурсов
  - декомпиляция игровых уровней
- Модуль "Unit Editor":
  - создание, удаление и редактирование NPC
  - создание, удаление и редактирование сквадов
  - создание, удаление и редактирование поведения сквадов
- Модуль "Trade Editor":
  - создание, удаление и редактирование торговцев
  - редактирование ассортимента торговцев
- Модуль "Weather Editor":
  - редактирование установок погоды
  - редактирование погодных циклов
- Модуль "Logs Analyzer":
  - перехват логов сразу после вылетов одной из платформ во время тестирования
  - анализ перехваченного лога для определения причины ошибки и её решения
  - загрузка лога и проделанных изменений для дальнейшего его анализа и изучения в случае отсутствия причины и решения у лога
  - уведомление пользователя системы, если для его неисследованного лога была обнаружена причина и решение
- Прочие функции:
  - просмотр всех файлов проекта в правой части главного окна **!**
  - открытие директории проекта в Проводнике **!**
  - изменение путей до платформ **!**
  - изменение пути до X-Ray SDK **!**
  - изменение автора и команды-разработчика в текущей версии программы **!**
  - вывод статистической информации о проект (дата создания, количество изменений, последнее изменение и т.д.)
  - запуск редакторов X-Ray SDK **!**
  - показ списка изменений исходного кода движка с приложением файлов, в которых были проделаны изменения
  - изменение файла fsgame.ltx
  - изменение файла user.ltx
  - открытие сайта dn.imesense.ru из программы **!**
  - вывод списка поддерживаемых горячих клавиш **!**
  - открытие сайта imesense.ru/octagon_docs из программы **!**
  - открытие сайта z3sa.ru и imesense.ru из программы **!**
  - проверка наличия обновлений у программы **!**
  - вывод всей информации о текущей ревизии программы **!**
  - возможность отправить сообщение о баге, замечании или предложении **!**

Конфигурация программного комплекса хранится в папке текущего пользователя/Application Data/Roaming/Octagon Studio/. Конфигурация, а также наработки проекта хранятся только в папке проекта/.octagon/. Все данные будут, кроме языковых пакетов, будут храниться в формате XML. Языковые пакеты имеют формат JSON.

Некоторые функции могут быть неточны, переработаны или удалены в связи с "погружением" разработчика в разработку модификаций. К сожалению, опыт в разработке модификаций у разработчика минимальный.
Regularfile - код идентификации для обычного файла. <br> Он объединяет самые различные виды файлов, такие как текст, изображения, бинарные файлы, библиотеки и т.д. 
<li>Создание: touch Regularfile.txt (просмотр того, что он создан ls -ld Regularfile.txt)
<li>Запись: vi Regularfile.txt (i редактор перейдёт в режим ввода текста. Можно удалять целые строки командой dd.<br> Для выхода введите Esc и Команда :wq сначала сохраняет файл со сделанными изменениями, а затем выходит из редактора vi. )
<li>Чтение: cat Regularfile.txt
<li>Удаление: rm Regularfile.txt (с помощью ls -ld Regularfile.txt проверяем, что файла нет)

![запись](https://user-images.githubusercontent.com/90246832/150921028-ed07d249-72f1-4ae9-b1e9-f43fa7992cfe.png)
![Typesoffile -](https://user-images.githubusercontent.com/90246832/150921735-b5fd12bf-fcfd-46f1-9f1b-703fdf3d921d.png)

“d” directory директория (каталог) 
<li>Создание: mkdir Directoria (просмотр того, что она создан ls -ld Directoria)
<li>Запись: Чтобы добавить файл в директорию нужно перейти в нее (cd Directoria) и создать файл (touch Regularfile.txt) или touch /home/user/Перезаписать/Regularfile
<li>Чтение: С помощью команды ls можно посмотреть, что находится в директории
<li>Переименовать: mv Directoria ~/Перезаписать
<li>Удаление: Чтобы удалить директорию надо вернуться в папку, в которой она была создана (cd ..). Команда rmdir Directoria. Однако если нужно удалить папку, которой содержатся файлы rm -r  Directoria/ (просмотр того, что она удалена ls -ld Directoria)
![Typesoffile d](https://user-images.githubusercontent.com/90246832/150922715-02346d97-dbc9-4b40-850e-3ffe72866fb6.png)


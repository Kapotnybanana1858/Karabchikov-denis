#!/bin/bash

echo "Wellcome "

select step in CREATEUSER DELETEUSER USERSEXISTENCE ENVIRONMENTVARIABLES EXIT
do
    case $step in
        CREATEUSER)
            read -p "Введите имя нового пользователя: " user
            withDir="-m"
            echo
            read -p "Введите путь к домашнему каталогу: " homeDir
            homeDir="-d ${homeDir}"
          useradd -N $withDir $homeDir $user
            read -p "Задайте пароль пользователя $user: " pswd
            chpasswd <<< "$user:$pswd"
            [[ $? == 0 ]] && echo "Ползователь создан" && exit 0;;
        DELETEUSER)
            read -p "Введите имя пользователя: " user
            userdel -r $user
            [[ $? == 0 ]] && echo "Пользователь успешно удален" && exit 0;;
        USERSEXISTENCE)
            read -p "Введите имя пользователя: " user
            if grep $user /etc/passwd
        then
        echo "Пользователь $user Существует"
            else
        echo "Пользователь $user не существует"
            fi
            exit 0;;
         ENVIRONMENTVARIABLES)
          echo
          read -p "Введите имя пользователя: " user
          cntn=y
            while [ $cntn != N ]
        do
              read -p "Введите Имя переменной = ""Значение переменной"": " envVar
          
          echo -e "export ${envVar}" >> $homedir/.bashrc
              echo -e "Переменная ${envVar} добавлена в ${user}"
              read -p "Добавьте еще одну переменную? [y/N]: " cntn
              if [ -z $cntn ]; then
            cntn=N
              fi
            done
          echo "Проверка наличия переменных в файле"
                gedit $home_directory/.bashrc
          exit 0;;
        EXIT)
            echo 'by EXIT!'
            exit 0;;
        *)
            echo "What is this?"
            exit 0;;
    esac
done


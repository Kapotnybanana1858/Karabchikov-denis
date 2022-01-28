#!/bin/bash

function CreateUser() {
 
  echo "Введите имя пользователя: "
  read username
    
  echo "Введите путь домашней директории: "
  read home_directory
  home_directory="-d ${home_directory}"
    
  useradd -s $SHELL "-m" $home_directory $username
 
  echo "Введите пароль: "
  read setPassword
  passwd $username
}

function DeleteUser() {
  echo "Введите имя пользователя для удаления: "
  read username
   
  echo
  userdel "-r" $username
}

function UserExist() {
  echo "Введите имя пользователя для проверки: "
  read username
   
  echo
  grep $username /etc/passwd
}

function addVarEnv() {
  echo "Введите имя пользователя для проверки: "
  read username

  echo "Введите переменную окружения: "
  read envVar
  homedir=$( getent passwd "$username" | cut -d: -f6 )
  echo "export ${envVar}" >> $homedir/.bashrc
  echo "variable ${envVar} add to ${username}"
 
}

echo "ДЗ2 CIS Esports"
while :
do
  echo " Вы можете создать пользователя (1); проверить, есть ли пользователь в системе(2); удалить пользователя(3).
 Добавить переменные окружения (4).
 Что Вы хотите сделать (введите [1/2/3/4]). Для выхода нажмите любую кнопку с клавиатуры"

  read choice_of_user
 
  case $choice_of_user in
    1)
      CreateUser
      ;;
    2)
      UserExist
      ;;
    3)
      DeleteUser
      ;;
    4)
      addVarEnv
      ;;
    *)
      break
      ;;
  esac
done

sudo bash dz2.sh


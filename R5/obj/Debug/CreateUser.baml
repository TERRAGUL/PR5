   M S B A M L   `   `   `  ����=  9R5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:R5R5  5   	       R5.CreateUser   5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:R5     5   	     � Title$  
CreateUser��5	   	   $	��300��6   $	��800��6)   
�������.��5
      �  � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      .+�5   
   �� -   5         ��Name$ NameSotr��5      $��Center=�6$   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Имя сотрудника��6A    �� TextAlignment$ Center=�6q    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��174��6�   �� 5   
   -   5        $ SurnameSotr��5      $��Center=�6'   $) #Фамилия сотрудника��6D   $ Center=�6x   $
 Wrap=�6�   $	��Top=�6�   $	��174��6�   $��0,30,0,0q�6�   �� 5   
   -   5        $ 
SalarySotr��5      $��Center=�6&   $* $Зарплата в доллярях��6C   $��0,64,0,0q�6x   $ Center=�6�   $
 Wrap=�6�   $	��Top=�6�   $	��174��6�   �� 5   
   -   5        $ 	LoginSotr��5      $��Center=�6%   $ 
Логин��6B   $ Center=�6i   $
 Wrap=�6�   $	��Top=�6�   $	��174��6�   $��	0,104,0,0q�6�   �� 5   
   -   5         ��Name$ Doldol��5      $��Center=�6#   $ Должность��6@   $��	0,180,0,0q�6k   $��Center=�6~   $	��Top=�6�   $	��174��6�   6�   G� 5   
   -   5         G�Name$ PasswordSotr��5      $��Center=�6,   $ Пароль��6I   $��	0,142,0,0q�6q   $��Center=�6�   $	��Top=�6�   $	��174��6�   �� 5   
   -   5        $��Создать��5      $��Center=�6#   $��	0,247,0,0q�6@   $	��Top=�6S   $	��174��6k   $��27��6w   6�   �� 5   
   $��Изменить��6   $��Center=�6$   $��	0,210,0,0q�6A   $	��Top=�6T   $	��174��6l   $��27��6x   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SotGRD��5      $��1��6#   $��10q�63   5      5       5!      
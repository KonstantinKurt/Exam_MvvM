   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      K GExam_mediaplayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Exam_mediaplayerExam_mediaplayer 5      !   Exam_mediaplayer.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      0localclr-namespace:Exam_mediaplayer     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Player��5	      $	��675��5
      $	��350��5       � DataContext 5        Exam_mediaplayer.ViewModel  5   
   .��5      � .+�5   
   �� -   5         ��Name$ listView��5      $	��365��5      $	��299��5      $��	10,10,0,0q�5      $
��Left=�5      $	��Top=�5      ��5      �� *Tracks+ �� SelectedItem 5      �� *Get_selected+.   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ MouseDoubleClick��6!   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6,   ��  �� Path$ 
Play_track�5      	 �� View	 5      �� 5       .P�5!      �� 
 �� Width$	
 260��5"      $!��Название файла��5$       �� DisplayMemberBinding 5#      �� *Name+5$      �� 5%      $	
 105��5&      $"��Размер файла,КБ��5(       5'      �� *Size+5(      5)      5+      �� 5,   
   -   5         ��Name$ button��5-      $	��212��5.      $��
445,11,0,0q�5/      $
��Left=�50      $	��Top=�51      $��Open folder��53      ��52      �� *
Get_tracks+53      �� 54   
   -   5         ��Name$ textBox��55      $	��268��56      $��52��57      $��
389,44,0,0q�58      $
��Left=�59      $	��Top=�5:       �� TextWrapping$
 Wrap=�5<      ��5;      �� *Playing_track+5<      �� 5=   
   -   5        $ button1��5>      $��52��5?      $��442,125,0,0q�5@      $
��Left=�5A      $	��Top=�5B      $
��Play��5D      ��5C      �� *
Play_track+5D      �� 5E   
   -   5        $ button2��5F      $��50��5G      $��506,125,0,0q�5H      $
��Left=�5I      $	��Top=�5J      $
��Stop��5L      ��5K      �� *
Stop_track+5L      �� 5M   
   -   5        $ button3��5N      $��48��5O      $��389,125,0,0q�5P      $
��Left=�5Q      $	��Top=�5R      $
��prev��5T       J� RenderTransformOrigin$ 0.868,0.533&�5U      ��5S      �� *Prev+5U      �� 5V   
   -   5        $ button4��5W      $��44��5X      $��613,125,0,0q�5Y      $
��Left=�5Z      $	��Top=�5[      $
��next��5]      ��5\      �� *Next+5]      �� 5^   
   -   5        $ button5��5_      $��47��5`      $��561,125,0,0q�5a      $
��Left=�5b      $	��Top=�5c      $��Pause��5e      ��5d      �� *Pause_command+5e      �� 5f   
   -	   5         ��Name$ slider��5g      $	��140��5h      $��454,205,0,0q�5i      $
��Left=�5j      $	��Top=�5k       � Value 5m      �� *Vol+�� 5n   
   -
   5        $ textBox1��5o      $	��140��5p      $��23��5q      $��454,236,0,0q�5r      $
��Left=�5s      $	��Top=�5t      $
 Wrap=�5v      ��5u      �� *Vol+5v      5z      5{      
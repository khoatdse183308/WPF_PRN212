   M S B A M L   `   `   `  ����f  bCandidateManagement_10092024_TruongDinhKhoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:CandidateManagement_10092024_TruongDinhKhoa+CandidateManagement_10092024_TruongDinhKhoa  5   	   B    <CandidateManagement_10092024_TruongDinhKhoa.JobPostingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:CandidateManagement_10092024_TruongDinhKhoa     5   	   -   5          � Title$  
JobPosting��5   	   $	��450��6   $	��800��6)   ���#ff0000.��5	      �  J� RenderTransformOrigin$ 0.425,0.473&�6   ��5
   
   �� 5       �� ImageSource$ /jobposting.jpg��6    � RowDefinitions 5   
   �� 5      $	��80* �6   �� 5      $
��137* �6   .+�5   
   �� $��Job Positing Management��6   $��Center=�62   $��43��6O   $��0,25,0,0q�6[   $	��Top=�6m   $	��286��6�   $��24(�6�   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ 	#FFFFD700��6#    � Offset$ 0Q�65   � 5      $ 	#FFFF8C00��6#   $ 1Q�65   5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   Color$	 	#FF4A4A4A��6#   
   	Direction$	
 320Q�65      ShadowDepth$ 3Q�6E      Opacity$	 0.6Q�6U   5      �� 5   
   $��Positing ID��6   ���#fff600$
��Left=�6;   $��	25,90,0,0q�6V   $	��Top=�6i   $��67��6�   �� 5   
   $��Title��6   ���#fff600$
��Left=�65   $��
25,142,0,0q�6P   $	��Top=�6d   $��28��6|   $��2��6�   $��67��6�   �� 5   
   -   5         ��Name$ txtJobPostingTitle��5      $
��Left=�6.   $��37��6I   $��
97,142,0,0q�6U   $��2��6i    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $	��155��6�   �� 5   
   $��Posted Date:��6   ���#fff600$
��Left=�6<   $��
400,92,0,0q�6W   $	��Top=�6k   $��77��6�   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ txtPostedDate��5       $
��Left=�6-   $��
491,93,0,0q�6H   $	��Top=�6\   $	��110��6t   �� 5!   
   $��Description��6   ���#fff600$
��Left=�6;   $��400,146,0,0q�6V   $	��Top=�6k   $��29��6�   $��2��6�   $��77��6�   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ DtgJobPosting��5"      $��1��6*   $��74,57,102,86q�6b   6x   �� 5#   
   -   5         ��Name$ BtnAdd��5#      ���#0000ff$	��Add��66   $
��Left=�6D   $��
82,213,0,0q�6_   $��1��6s   $	��Top=�6�   $��41��6�   $��69��6�   6�   �� 5$   
   -   5        $ 	BtnUpdate��5$      ���#32cd32$��Update��69   $
��Left=�6J   $��246,213,0,0q�6e   $��1��6z   $	��Top=�6�   $��41��6�   $��69��6�   6�   �� 5%   
   -   5        $ 	BtnDelete��5%      ���#8b0000$��Delete��69   $
��Left=�6J   $��448,213,0,0q�6e   $��1��6z   $	��Top=�6�   $��41��6�   $��69��6�   6�   �� 5&   
   -   5        $ BtnClose��5&      ���#00b7eb$��Close��68   $
��Left=�6H   $��629,213,0,0q�6c   $��1��6x   $	��Top=�6�   $��41��6�   $��69��6�   6�   �� 5'   
   -	   5        $ txtDescription��5'      $
��Left=�6*   $��56��6E   $��491,146,0,0q�6Q   $��2��6f   $
 Wrap=�6w   $��TextBox��6�   $	��Top=�6�   $	��180��6�   �� 5(   
   -
   5        $ txtPostingID��5(      $
��Left=�6(   $��39��6C   $��
124,90,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��128��6�   5*      5+      
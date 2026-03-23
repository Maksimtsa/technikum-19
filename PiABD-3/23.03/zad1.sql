SELECT Nazwisko, if(wiek >= 18, 'pełnoletni', 'nieletni') as status
FROM mtab

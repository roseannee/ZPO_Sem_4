# Table of Contents
1. [Lab 1](#lab1)
2. [Lab 2](#lab2)
3. [Lab 3](#lab3)
4. [Lab 4](#lab4)
5. [Lab 5](#lab5)
6. [Lab 6](#lab6)
7. [Lab 7](#lab7)
8. [Lab 8](#lab8)
9. [Lab 9](#lab9)
10. [Project](#project)

<br/>
 
# Lab 1 - Zdarzenia <a name="lab1"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab1)<br/><br/>
Proszę napisać program rysunkowy o następujących funkcjonalnościach:
1. panel wypełniający prawie całe okno (powierzchnia do rysowania),
2. na dole pasek statusu, pokazujący aktualne współrzędne kursora,
3. … i wciśnięte przyciski myszy,
4. kliknięcie w panel (lewym przyciskiem) powoduje narysowanie koła,
5. kliknięcie w panel (prawym przyciskiem) powoduje narysowanie kwadratu,
6. po wjechaniu na teren panelu zmienia się kształt kursora,
7. narysowane figury nie znikają po zasłonięciu i odsłonięciu okna,
8. jest możliwe przesunięcie narysowanej figury (przeciągnięcie lewym przyciskiem, przy wciśniętym CTRL).

<br/>

# Lab 2 - Delegaty <a name="lab2"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab2)<br/><br/>
Proszę napisać program, testujący użycie delegatów, o następujących funkcjonalnościach:
1. możliwość wybrania/zapamiętania metody wybranej przez użytkownika w zmiennej delegatu (kwadrat, pierwiastek, odwrotność),
2. możliwość wywołania wcześniej zapamiętanej metody i wyświetlenia wyniku,
3. możliwość dodania do (innej niż wyżej) zmiennej delegatu kilku metod i wywołania tej listy metod (zmiana koloru tła, zmiana koloru czcionki, zmiana rozmiaru czcionki etykiety),
4. możliwość wykonania wybranej operacji na kolekcji liczb rzeczywistych (kwadrat, pierwiastek, odwrotność) - należy napisać metodę z parametrem typu delegatu,
5. możliwość sortowania rosnąco lub malejąco liczb rzeczywistych - należy napisać metodę sortującą, która otrzymuje metodę porównującą jako parametr,
6. możliwość sortowania rosnąco lub malejąco napisów - metoda sortująca z punktu 5 powinna być uogólniona, tzn. działać zarówno dla liczb, jak i napisów.

<br/>

# Lab 3 - Okna dialogowe <a name="lab3"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab3)<br/><br/>
Proszę napisać program do przechowywania listy osób o następujących funkcjonalnościach:
1. okno główne wyświetla listę osób (należy napisać klasę przechowującą dane pojedynczej osoby z ToString( )),
2. okno głowne zawiera przycisk "Dodaj", wyświetlający modalne okienko dialogowe (pkt 3) i dodający wprowadzone dane do listy osób,
3. okienko dialogowe pozwala podać imię, nazwisko, rok urodzenia i miasto zamieszkania,
4. okienko dialogowe zawiera przyciski OK i Anuluj (po anulowaniu osoba nie jest dodawana do listy),
5. okno głowne zawiera przycisk "Dodaj wiele", wyświetlający niemodalne okienko dialogowe (pkt 6), które pozwala dodać dane wielu osób do listy,
6. okienko dialogowe zawiera przyciski Dodaj i Zamknij; po kliknięciu Dodaj osoba dodawana jest do listy w oknie głównym; okno dialogowe jest zamykane po kliknięciu Zamknij,
7. okno główne zawiera przycisk "Edytuj", który wyświetla modalne okienko dialogowe (pkt 4), ale wypełnione danymi zaznaczonej osoby i służy do modyfikacji danych tej osoby,
8. okienko dialogowe (pkt 4) ma tytuł "Dodawanie osoby" lub "Edytowanie osoby" w zależności od tego, którym przyciskiem zostało otworzone i zamiast przycisku OK ma przycisk "Dodaj" lub "Edytuj" w zależności jak wyżej.

<br/>
 
# Lab 4 - Wyrażenia lambda i metody rozszerzające <a name="lab4"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab4)<br/><br/>
Proszę napisać i umożliwić wypróbowanie następujących wyrażeń lambda
1. x do n (bez korzystania z gotowej metody)
2. stworzenie napisu składającego się z n podanych znaków (np. „aaaaaaaa”)
3. metoda zwracająca wyrażenie lambda podnoszące liczbę do potęgi określonej parametrem metody
4. napisanie własnej metody sortującej, która sortuje na podstawie delegatu
5. dwa wyrażenia lambda do sortowania liczb malejąco i rosnąco (do metody z pkt 3)
       
Proszę napisać metody rozszerzające klasę String (oraz GUI do przetestować te metody)
1. Metoda "zwiększająca" co drugą literę, a zmniejszająca co drugą, „ala ma kota” => „AlA Ma KoTa”, „ALA MA KOTA” => „AlA Ma KoTa”
2. Metoda usuwająca wszystkie samogłoski z napisu, „ala ma kota” => „l m kt”
3. Metoda zwracająca tablicę z długościami poszczególnych wyrazów w napisie,
4. Metoda zwracająca prawdę lub fałsz, sprawdzająca, czy napis jest zdaniem (początek z wielkiej, kropka na końcu),
5. Metoda rozszerzająca IEnumerable, zwracająca element, który występuje najwięcej razy,

<br/>

# Lab 5 - Wypożyczalnia sprzętu narciarskiego <a name="lab5"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab5)<br/><br/>
Proszę napisać program okienkowy, korzystając z biblioteki WPF lub UWP, służący do obsługi wypożyczalni sprzętu narciarskiego o następującej funkcjonalności:
1. wprowadzenie imienia i nazwiska klienta
2. wprowadzenie ilości dni wypożyczenia
3. wprowadzenie ceny za komplet
4. wyliczenie kosztu i dopisanie powyższych danych do listy wypożyczeń, wyświetlanej w dużym polu edycyjnym, ListBox'ie lub innej kontrolce 
5. dodanie elementów opcjonalnych (kask, gogle, kijki)
6. wybranie daty początkowej i końcowej (ilość dni obliczana na tej podstawie automatycznie)

Ważne: 
- używamy kontenerów w ten sposób, żeby okno dało się rozciągać i kontrolki wykorzystywały sensownie tę dodatkową przestrzeń,
- nie używamy Designera Visual Studio, tylko piszemy w XAML'u.

<br/>
 
# Lab 6 - LINQ <a name="lab6"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab6)<br/><br/>
Napisz program, który będzie umożliwiał stworzenie kolekcji napisów oraz jej (z użyciem LINQ):
1. filtrowanie (3 kryteria)
2. sortowanie (rosnąco i malejąco)
3. przekształcanie (3 sposoby)
4. badanie (sprawdzanie, czy zawiera; 3 sposoby)
5. agregowanie (np. sumowanie; 3 sposoby)
6. oprócz kolekcji napisów kolekcja osób (wystarczy 1 przykład w każdym punkcie)

<br/>
 
# Lab 7 - Data binding <a name="lab7"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab7)<br/><br/>
Proszę stworzyć program, pozwalający na przechowywanie bazy osób (ew. można zmodyfikować program z wypożyczeniami). Program powinien posiadać następujące funkcjonalności:
1. wyświetlanie listy osób lub wypożyczeń w wybranej kontrolce, przeznaczonej do wyświetlania kolekcji,
2. powiązanie kolekcji osób w code behind z kontrolką z punktu 1,
3. wyświetlanie każdego elementu kolekcji na podstawie szablonu (ItemTemplate); wyświetlamy tylko najważniejsze dane,
4. po zaznaczeniu elementu kolekcji, w oknie pojawiają się wszystkie dane tego elementu (używamy bindingu),
5. wyświetlone dane zaznaczonego elementu są edytowalne (automatycznie, binding dwukierunkowy),
6. dodanie lub usunięcie elementu do kolekcji w code behind jest od razu (automatycznie) widoczne w interfejsie użytkownika, 
7. modyfikacja danych elementu w code behind jest od razu widoczna na liście i w polach edycyjnych (INotifyPropertyChanged),
8. możliwość dodania zdjęcia osoby (miniaturka widoczna na liście, większe zdjęcie widoczne po zaznaczeniu elementu).

<br/>

# Lab 8 - Taski: znajdowanie liczb pierwszych <a name="lab8"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab8)<br/><br/>
Program, który znajduje liczby pierwsze w podanym zakresie:
1. Program okienkowy
2. Szukanie liczb pierwszych z użyciem Tasków
3. W oknie wyświetlamy komunikaty "Co się aktualnie dzieje?"
4. Na koniec wyświetlamy informację, ile liczb pierwszych zostało znalezionych
5. Rozdzielamy przeszukiwany zakres na podaną liczbę podzakresów (Tasków)
6. Startujemy wszystkie Taski z 5 "równolegle"
7. Wyniki (ilość liczb pierwszych) aktualizujemy po każdym zakończonym Tasku
8. Pokazujemy paskiem postępu, ile Tasków się już zakończyło
9. Użycie Tasków dzieci, sprawdzających, czy dana liczba jest liczbą pierwszą

<br/>

# Lab 9 - Async await <a name="lab9"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/lab9)<br/><br/>
Proszę napisać program okienkowy, który pozwala na podanie adresów kilku stron internetowych, a następnie pobranie ich zawartości w sposób asynchroniczny. Pobrana zawartość powinna być wyświetlona w postaci tekstowej (HTML - źródło strony). 
Wymagane funkcjonalności:
1. możliwość wprowadzenia co najmniej trzech adresów (w wersji minimum mogą być trzy pola edycyjne),
2. przycisk "Pobierz" uruchamiający asynchroniczne pobieranie treści spod wszystkich trzech adresów,
3. dowolny element GUI, pozwalający pokazać, że w czasie pobierania kontrolki nie są zablokowane i użytkownik może z nich korzystać, 
4. "zrównoleglenie pobierania" (w wersji na 3, kolejne pobieranie rozpoczyna się po zakończeniu poprzedniego),
5. obsługa dowolnej ilości adresów (np. ListBox z możliwością dodawania i usuwania adresów),
6. wyświetlanie informacji, które zadania pobierania się już zakończyły (w takiej kolejności, w jakiej faktycznie to nastąpiło).

<br/>

# Project <a name="project"></a>
[folder link](https://github.com/roseannee/ZPO_Sem_4/tree/master/Project/2048)<br/><br/>
[Specyfikacja wymagań.pdf](https://github.com/roseannee/ZPO_Sem_4/files/11149728/Specyfikacja.wymagan.pdf)

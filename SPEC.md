Note: Még változhat a design, funkciólista bővülhet, végpontlista nevek változhatnak bővülhetnek
1. Rendszerleírás: 
	- Mindig is szerettem a FromSoftware játékait a kihívás miatt, éppen ezért ezek a játékok azért híresek, mert igazán nehéz a játékaikat végigjátszani. Ez annak köszönhető, hogy a bennük lévő változatos bossok egy elég nehéz kihívás elé állítanak. Az alkalmazás célja az lenne, hogy a felhasználó játékokra lebontva tudja hatékonyan vezetni, hogy melyik boss-t győzte már le. Az alkalmazásban külön meg lehet nézni az összes boss adatait, rá lehet keresni bossokra. Külön profilokkal kell bejelentkezni, ahol profilonként lehet vezetni az előrehaladást. (Disscussion thread lehetőség, ha időm engedi)
2. Funkciólista: 
	- Bossok nyilvántartása, megjelenítése listaként
	- Bossok hozzáadása a saját listához, akiket már a user legyőzött
	- Bossok részletes megteklintése
	- Bossok szűrése játék alapján
	- Bejelentkezés
	- Regisztráció
3. Végpont lista:
	- /bosses - Összes boss lekérése
	- /bosses/{id} - Egy adott boss részletes adatainak lekérése
	- /bosses/add - Új boss hozzáadása
	- /users/bosses/add/{bossId} - Egy boss hozzáadása a user listájához
	- /users/register - Regisztráció
	- /users/login - Bejelentkezés
4. Technológiák:
	- Backend: C#, ASP.NET Core framework
	- Frontend: Angular, CSS
5. Tervezett design:
	 - Ez csak egy vázlat nem végleges design, de valami hasonló lenne az elképzelés.
	 ![[Pasted image 20240421144636.png]]
	 ![[Pasted image 20240421144605.png]]

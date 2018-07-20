# Kaktus - Dobíječka (1.0.1 - 20.07.2018)
### ⚠️Před provedením aktualizace si ověřte, zda máte vypnuté automatické zapnutí aplikace při spuštění Windows. Více v Q&A (Jak program aktualizuji?)

Jedná se o velice jednoduchou a hlavně **amaterskou** aplikaci, která vám bude každých **5 minut** zjišťovat aktuální stav ze serveru [https://www.mujkaktus.cz/](https://www.mujkaktus.cz/ "https://www.mujkaktus.cz/") zda je dobíječka aktivní či není.

V případě, že bude dobíječka aktivní, tak vás bude **každých 5 minut** otravovat, dokud program neukončíte pro daný den.

# Funkce a výhody
- Každých 5 minut kontroluje stav dobíječky a nové aktualizace pro aplikaci.
- Upozorní vás formou vyskakovací bubliny a zároveň se změní barva ikony v dolním panelu na žlutou.
- Lze zapnout/vypnout automatické zapnutí při spuštění Windows.
- **Zcela otevřený projekt**, díky němuž si můžete kód lehce přizpůsobit (tj. nastavit si např. jiný interval pro kontrolu stavu dobíječky.)

# Ke stažení
**Instalační soubor** ke stažení **[zde](https://github.com/Fastmancz/Kaktus/files/2195626/Install.-.1.0.0.-.15.07.2018.zip "zde")**. (1.0.1 - 20.07.2018)

**Projekt** ke stažení **[zde](https://github.com/Fastmancz/Kaktus/archive/1.0.1.zip "zde")**. (1.0.1 - 20.07.2018)

# Obecné informace
- **Nejedná** se v žádném případě o oficiální aplikaci ze strany společnosti 
T-Mobile Czech Republic a.s. nebo značky Kaktus.
- Tento program **není digitálně podepsaný**, to znamená, že **může mít problémy s antivirovými programy**, proto jej doporučuji přidat do výjimek. V případě, že mi z nějakého důvodu nevěříte, můžete si onen projekt stáhnout a sami si vytvořit instalační soubor. **Manuál k samotnému postupu kompilace poskytovat nebudu (je to zdlouhavé)**. Byl použit software od společnosti Microsoft: [Visual Studio - Community](https://visualstudio.microsoft.com/cs/vs/ "Visual Studio - Community").
- **Vyhrazuji si právo**, kdykoliv odstavit službu, jenž poskytuje informace o stavu dobíječky.

- **Já, jakožto autor tohoto softwaru, nenesu zodpovědnost za případné škody způsobené na vašem zařízením, kód může obsahovat určité chyby, a proto nemůžu garantovat 100% záruku spolehlivosti. Jedná se o amaterskou aplikaci. I když byla aplikace plně testována bez známky chyb, je možné, že v určitých situacích nějaké chyby můžou nastat. Proto vás prosím o zaslání dané chyby [sem (Issues)](https://github.com/Fastmancz/Kaktus/issues "sem (Issues)")**.

# Q&A
- **Je program zdarma?** Ano, program je zdarma.
- **Jak program aktualizuji?** V případě, že máte zapnuté automatické zapnutí aplikace při spuštění Windows, tak jej nejprve vypněte a následně jděte do Ovládacích panelů - Programy a funkce a odinstalujte program (Kaktus - Dobíječka). Program se instaluje formou ClickOnce, a proto nemůžu detekovat odinstalování programu, takže by v registru zůstal zbytečný záznam. Pokud jste program již odinstalovali a nepostupovali jste podle návodu výše, tak stačí záznam smazat z registru (CTRL+R) - regedit, vložit do řádku (\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run) a Enter. V seznamu uvidíte (Kaktus - Dobijecka), stačí tento záznam odstranit. Hotovo.
- **Jak to celé funguje?** Každých 5 minut vyvolá program dotaz pro stažení JSON dat ze stránky [https://fastmancz.000webhostapp.com/api/kaktus/](https://fastmancz.000webhostapp.com/api/kaktus/ "https://fastmancz.000webhostapp.com/api/kaktus/") a získaná data promítne do systému aplikace. Tato data jsou brána formou jednoduchého PHP kódu.
- **Můžu aplikaci provozovat na svém webu?** Ano, stačí stáhnout kompletní balíček a přepsat v programu proměnnou *website* na svůj vlastní web. Následně obsah složky *PHP* dejte na svoje FTP webu. Server musí mít nainstalovaný PHP a dynamická stránka nesmí obsahovat nic jiného než JSON data (v opačném případě hrozí pád aplikace.) Jen poznamenám, že tímto krokem již nebude mít aplikace kontrolu nad aktuální verzí programu.
- **Poradíte mi, jak to mám zkompilovat?** Ne, ale existuje spousta návodů na YouTube/Google jak toho docílit. Jak již zbylo zmíněno výše, program je psán ve Visual Studio - Community (C#).
- **Proč mi nejde program spustit?** Program by měl podporova x86, x64 bitovou verzi Windows XP, Windows 7 až Windows 10. Pro spuštění programu je potřeba mít nainstalovaný .net framework 4.0 (standardně je již v systému nainstalován.)
- **Jsou o mně ukládaná nějaká data?** Ne, program nezaznamenává žádná data či jiný Váš obsah.
- **Jakým způsobem se provádí automatické spuštění aplikace?** Aplikace, v případě, že si tak sami přejete, uloží do registru (HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run) záznam o spuštění aplikace (Kaktus - Dobijecka). V opačném případě záznam smaže.
- **Proč mě antivirus uporozňuje, že je program nebezpečný?** Jak již bylo řečeno, program není digitálně podepsaný, to znamená, že může být pro ostatní antiviry i Windows potenciálně nebezpečený. Stačí tento program přidat do výjimek.
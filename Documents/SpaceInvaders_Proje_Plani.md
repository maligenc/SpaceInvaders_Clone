# Space Invaders Clone — Proje Planı

> **Faz 1 / "Sıfırdan Portföye" yol haritası**
> Amaç: 8 haftada Unity ile bir Space Invaders klonu geliştirip WebGL olarak itch.io'da **yayınlamak** ve süreci devlog ile belgelemek.
> Bu proje, oyun geliştirici kariyer değişimi hedefinin ilk somut portföy parçasıdır.

---

## 1. Proje Künyesi

| | |
|---|---|
| **Motor** | Unity 6.5 (6000.5.2f1) — Universal 2D (URP) template |
| **Dil** | C# |
| **Hedef platform** | WebGL (Web Build Support) → itch.io |
| **Süre** | 8 hafta (haftada ~4 saat, 2 seans) |
| **Repo** | github.com/maligenc/SpaceInvaders_Clone |
| **Çalışma düzeni** | 2 makine (masaüstü + laptop), git ile senkron |

### Başarı tanımı
Proje şu üç koşul sağlandığında "bitti" sayılır:
1. Oyun itch.io'da tarayıcıdan oynanabilir durumda yayında.
2. Tüm Must Have maddeleri tamamlanmış.
3. Devlog'da en az 8 haftalık yazı yayınlanmış.

---

## 2. Kapsam — MoSCoW Analizi (dondurulmuş)

> Bu bölüm **donmuştur**: yeni madde yalnızca Won't Have'e eklenebilir.
> Kapsam tartışmalarında hakem soru: *"Bu özellik yayın tarihini riske atıyor mu?"*

### Must Have
- [ ] Oyun WebGL olarak build alınıp itch.io'da yayınlanacak
- [ ] UI: Start ana menüsü (yalnızca "Start" butonu)
- [ ] UI: Oyun içi HUD (skor + can)
- [ ] UI: Game Over ekranı (replay butonu ile)
- [ ] UI: Oyun tamamlanınca Congrats ekranı
- [ ] Oyun en az 3 stage içerecek (3. stage sonunda oyun biter → Congrats)
- [ ] Alienlar her stage'de daha hızlı hareket edecek
- [ ] Her alien tek atışta ölecek
- [ ] Alienlar oyuncuya ateş edecek

### Should Have
- [ ] Oyuncu ile alienlar arasında bariyerler (4 vuruş dayanır, sonra yıkılır)
- [ ] Alien özel saldırısı: isabet alan oyuncu yavaşlar
- [ ] Oyuncunun tetiklediği, alan hasarı veren bir özel atış
- [ ] Ekstra can

### Could Have
- [ ] Ölüm animasyonu
- [ ] Süslü menü / animasyonlu geçişler

### Won't Have
- Ayarlar (settings) ekranı
- Kayıt (save state) sistemi

---

## 3. Haftalık Görev Listesi

### Hafta 1 — Kurulum ve merhaba dünya ✅ (büyük ölçüde tamamlandı)
- [x] Unity Hub + Unity 6.5 kurulumu (Web Build Support modülü dahil)
- [x] Universal 2D template ile proje oluşturma
- [x] GitHub repo + Unity .gitignore (alt klasör için `/` düzeltmesi yapıldı)
- [x] MoSCoW dokümanı commit'lendi
- [x] Editörde bilinçli gezinti: Scene/Game view, Inspector, Hierarchy, Play modu tuzağı
- [x] İlk script: kare sprite ok tuşlarıyla sağa-sola hareket ediyor
- [x] En az 2 anlamlı commit

**Bitti kriteri:** Kare ok tuşlarıyla hareket ediyor + repo'da temiz commit geçmişi var.

### Hafta 2 — Oyuncu ve ateş
- [x] Oyuncu gemisi ekran sınırları içinde (clamp)
- [x] Space ile mermi ateşleme (prefab + Instantiate)
- [x] Mermiler ekran dışına çıkınca Destroy
- [x] Ateş hızına cooldown

**Bitti kriteri:** Sahne çöplüğe dönmeden sürekli ateş edilebiliyor.

### Hafta 3 — Düşmanlar geliyor
- [x] Alien prefab'ı; mermi çarpınca ölüyor (Collider2D + OnTriggerEnter2D)
- [x] Kodla 5x8 alien dizisi spawn (iç içe for döngüsü)

**Bitti kriteri:** Dizi ekranda, alienlar vurulunca ölüyor.

### Hafta 4 — Klasik hareket paterni ⚠ zor hafta
- [x] Dizi topluca sağa/sola hareket; kenarda bir satır aşağı inip yön değiştirme
- [x] Hareket mekaniğinin pürüssüzleşmesi lazım
- [x] Alien sayısı azaldıkça hız artışı

**Bitti kriteri:** Orijinal Space Invaders hareket hissi çalışıyor.
*Not: Bu hafta tek göreve ayrılmıştır, takılmak normaldir. Uzarsa sıkıştırma, kaydır.*

### Hafta 5 — Ölüm ve skor
- [x] Alienlar rastgele aralıklarla aşağı ateş ediyor
- [x] Oyuncuya 3 can; vurulunca azalıyor
- [x] Skor sistemi + HUD (Canvas + TextMeshPro)
- [x] Kaybetme koşulları: canlar biterse VEYA alienlar oyuncu hizasına inerse

**Bitti kriteri:** Oyun kazanılabiliyor ve kaybedilebiliyor.

### Hafta 6 — Oyun döngüsünü kapat
- [x] Akış: Start menüsü → oyun → Game Over/Congrats → yeniden başlat
- [x] 3 stage yapısı; her stage'de hız artışı; 3. stage sonu → Congrats
- [ ] Sesler: ateş, patlama, game over (freesound.org / sfxr)


**Bitti kriteri:** Oyun baştan sona, elle müdahalesiz oynanabiliyor. **Tüm Must Have'ler bu hafta sonunda kapanmış olmalı.**

### Hafta 7 — Cila + Should Have penceresi
- [ ] Patlama efekti (particle veya sprite animasyonu)
- [ ] Kenney.nl sprite paketiyle görsel yenileme (kendin çizme!)
- [ ] 1-2 "juice" dokunuşu (ekran titremesi vb.)
- [ ] İlk playtest: bir arkadaşa oynat, not al
- [ ] *Vakit kalırsa Should Have sırası: özel atış → bariyerler → ekstra can → alien özel saldırısı*

**Bitti kriteri:** Playtest yapıldı, en az bir geri bildirim işlendi.

### Hafta 8 — Yayın
- [ ] WebGL build (tarayıcıda test edilmiş)
- [ ] itch.io sayfası: ekran görüntüleri, açıklama, kapak görseli
- [ ] Devlog kapanış yazısı: "8 haftada ilk oyunumu yayınladım"
- [ ] LinkedIn paylaşımı

**Bitti kriteri = Proje bitti kriteri:** Oyun linki herkese açık ve çalışıyor.

---

## 4. Çalışma Kuralları

### Kapsam
1. Bu listede olmayan hiçbir özellik eklenmez. Yeni fikirler "Faz 2 not defteri"ne yazılır.
2. Bir hafta bitmezse sıkıştırılmaz, takvim kaydırılır. 8 hafta 10 hafta olabilir; yarım proje olamaz.
3. Should Have'ler yalnızca tüm Must Have'ler kapandıktan sonra (Hafta 7+) ele alınır.

### Seans disiplini
- Haftada 2 seans: 1 hafta içi akşamı (~2 saat) + 1 hafta sonu (~2-3 saat).
- Her seans tek cümlelik hedefle başlar (örn. "bu seans alien dizisi spawn olacak").
- Her haftanın son 20 dakikası devlog yazısına ayrılır — ayrı zaman aranmaz.

### Git / iki makine düzeni
- Commit mesajları ne yapıldığını söyler ("Add enemy grid spawner"); "update/fix/asdf" yasak.
- Makine değiştirmeden önce **push**, oturmadan önce **pull**.
- Aynı sahne iki makinede aynı anda düzenlenmez (sahne dosyaları merge edilemez).
- İki makinede de aynı Unity sürümü (6000.5.2f1) kurulu olmalı.
- Şüphede kontrol komutu: `git status --porcelain | grep -iE "library|temp|logs"` → çıktı boş olmalı.

---

## 5. Devlog

- **Altyapı:** GitHub Pages (`maligenc.github.io` repo'su, Jekyll). Site tasarımıyla oynamak yasak — o iş oyun yapmaktan kaçmaktır.
- **Sıklık:** Haftada 1 yazı, seansın son 20 dakikasında.
- **İlk yazı (Hafta 0):** MoSCoW hikâyesi — "Oyun yapmaya kod yazarak değil kapsam dokümanıyla başladım."

### Yazı şablonu
```markdown
# Hafta N — [kısa başlık]

## Bu hafta ne yaptım
(3-4 cümle + mutlaka 1 ekran görüntüsü veya GIF)

## Ne ters gitti
(Yazının en değerli kısmı: hata, yanlış varsayım, çözüm süreci)

## Ne öğrendim
- (1-2 madde)

## Gelecek hafta
(Tek cümle — kendine verdiğin söz)
```

---

## 6. Faz 2 Not Defteri

> Kapsam dışı fikirler buraya. Bu projede YAPILMAZLAR.

- (boş — ilk "power-up ekleseydim" anında burası dolacak)
- [ ] streak counter
- [ ] Score bearing


---

*Son güncelleme: 4 Temmuz 2026 — Hafta 1 devam ediyor.*

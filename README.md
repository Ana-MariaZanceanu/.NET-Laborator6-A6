# .NET-Laborator6-A6

Bîrnoveanu Alexandru, Botez Georgiana, Cozma Cătălin, Gagea Eusebiu, Stan Laura, Zănceanu Ana-Maria - grupa 3A6

În urma testelor făcute am observat că în momentul în care facem un update cu un JSON ce nu conține toate câmpurile aferente unei entități, se modifică și câmpurile ce nu există în JSON-ul dat în body, punându-se valorile default a tipurilor de date corespunzătoare variabilelor - exemplu: dacă nu există câmpul description in JSON acesta va fi totuși modificat cu valoarea null, isDone cu valoarea false, etc.

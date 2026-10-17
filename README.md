\# TaskFlow API

API do tworzenia i zarządzania zadaniami



\## Technologie

* c#
* .NET SDK
* ASP.NET Core
* Git i GitHub



\## Uruchomienie i środowisko

Git

.NET SDK w wersji zgodnej z projektem



Póki co to wstęp



\## AUtor

Kacper Wesoły, numer albumu 175489



\## Status projektu

Projekt znajduje się na etapie przygotowania, bez funkcjonalności biznesowej

Zmiany będą na oddzielnWych branchach

\## Model domenowy

Projekt zyskał model domenowy, pojawiły się klasy: Project do grupowania zadań, zawiera identyfikator, nazwe, opis i liste zadań
TaskItem reprezentuje pojedyncze zadanie nalezace do projektu, Posiada tytuł, opcjonalny opis, status, i identyfikator projektu,
Comment służy jako komentarz do zadania, zawiera treść, autora, id zadania,
TaskStatus określa na jakim etapie znajduje się wykonywane zadanie,
CreateTaskItemDto to model danych wejściowych wykorzystywanych przy tworzeniu zadań.

Relacje: 1 projekt -> wiele zadań
1 zadanie -> wiele komentarzy


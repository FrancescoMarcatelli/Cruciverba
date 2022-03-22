import json


with open("rawCruciverba.json", "r") as f:
    collezione = json.load(f)

elencoCruciverba = []
elencoSuggerimenti = []

idCruciverba = 1
idSuggerimento = 1 
for o in collezione:
    soluzione = o["res"]
    width = o["width"]
    height = o["height"]
    
    elencoCruciverba.append({
        "Id": idCruciverba,
        "Solution": soluzione,
        "Width": width,
        "Height": height
    })
    
    
    for sOriz in o["cluesHoriz"]:
        numero = sOriz["id"]
        descrizione = sOriz["clue"]
        isHoriz = True

        elencoSuggerimenti.append({
            "SuggerimentoId": idSuggerimento,
            "Numero": numero,
            "Descrizione": descrizione,
            "isHoriz": isHoriz,
            "FK_Cruciverba": idCruciverba
        })


        idSuggerimento += 1



    for sVert in o["cluesVert"]:
        numero = sVert["id"]
        descrizione = sVert["clue"]
        isHoriz = False

        elencoSuggerimenti.append({
            "SuggerimentoId": idSuggerimento,
            "Numero": numero,
            "Descrizione": descrizione,
            "isHoriz": isHoriz,
            "FK_Cruciverba": idCruciverba
        })

        idSuggerimento += 1

    idCruciverba += 1

with open("elencoCruciverba.json", "w") as f:
    json.dump(elencoCruciverba, f)

with open("elencoSuggerimenti.json", "w") as f:
    json.dump(elencoSuggerimenti, f)


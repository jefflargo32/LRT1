Public Class Form1
    Dim num1, num2 As Decimal
    Dim operan As Integer
    Dim operanselected As Boolean = False
    ' Single Journey Baclaran
    Const SingleBaclaranEDSA = 15
    Const SingleBaclaranLibertad = 15
    Const SingleBaclaranGilPuyat = 15
    Const SingleBaclaranVitoCruz = 15
    Const SingleBaclaranQuirino = 15
    Const SingleBaclaranPedroGil = 20
    Const SingleBaclaranUN = 20
    Const SingleBaclaranCentral = 20
    Const SingleBaclaranCarriedo = 20
    Const SingleBaclaranDoroteoJose = 20
    Const SingleBaclaranBambang = 20
    Const SingleBaclaranTayuman = 30
    Const SingleBaclaranBlumentritt = 30
    Const SingleBaclaranAbadSantos = 30
    Const SingleBaclaranRPapa = 30
    Const SingleBaclaran5thAvenue = 30
    Const SingleBaclaranMonumento = 30
    Const SingleBaclaranBalintawak = 30
    Const SingleBaclaranRoosevelt = 30
    ' Single Journey EDSA
    Const SingleEDSABaclaran = 15
    Const SingleEDSALibertad = 15
    Const SingleEDSAGilPuyat = 15
    Const SingleEDSAVitoCruz = 15
    Const SingleEDSAQuirino = 15
    Const SingleEDSAPedroGil = 15
    Const SingleEDSAUN = 20
    Const SingleEDSACentral = 20
    Const SingleEDSACarriedo = 20
    Const SingleEDSADoroteoJose = 20
    Const SingleEDSABambang = 20
    Const SingleEDSATayuman = 20
    Const SingleEDSABlumentritt = 30
    Const SingleEDSAAbadSantos = 30
    Const SingleEDSARPapa = 30
    Const SingleEDSA5thAvenue = 30
    Const SingleEDSAMonumento = 30
    Const SingleEDSABalintawak = 30
    Const SingleEDSARoosevelt = 30
    ' Single Journey Libertad
    Const SingleLibertadBaclaran = 15
    Const SingleLibertadEDSA = 15
    Const SingleLibertadGilPuyat = 15
    Const SingleLibertadVitoCruz = 15
    Const SingleLibertadQuirino = 15
    Const SingleLibertadPedroGil = 15
    Const SingleLibertadUN = 15
    Const SingleLibertadCentral = 20
    Const SingleLibertadCarriedo = 20
    Const SingleLibertadDoroteoJose = 20
    Const SingleLibertadBambang = 20
    Const SingleLibertadTayuman = 20
    Const SingleLibertadBlumentritt = 20
    Const SingleLibertadAbadSantos = 30
    Const SingleLibertadRPapa = 30
    Const SingleLibertad5thAvenue = 30
    Const SingleLibertadMonumento = 30
    Const SingleLibertadBalintawak = 30
    Const SingleLibertadRoosevelt = 30
    ' Single Journey Gil Puyat
    Const SingleGilPuyatBaclaran = 15
    Const SingleGilPuyatEDSA = 15
    Const SingleGilPuyatLibertad = 15
    Const SingleGilPuyatVitoCruz = 15
    Const SingleGilPuyatQuirino = 15
    Const SingleGilPuyatPedroGil = 15
    Const SingleGilPuyatUN = 15
    Const SingleGilPuyatCentral = 20
    Const SingleGilPuyatCarriedo = 20
    Const SingleGilPuyatDoroteoJose = 20
    Const SingleGilPuyatBambang = 20
    Const SingleGilPuyatTayuman = 20
    Const SingleGilPuyatBlumentritt = 20
    Const SingleGilPuyatAbadSantos = 20
    Const SingleGilPuyatRPapa = 30
    Const SingleGilPuyat5thAvenue = 30
    Const SingleGilPuyatMonumento = 30
    Const SingleGilPuyatBalintawak = 30
    Const SingleGilPuyatRoosevelt = 30
    ' Single Journey Vito Cruz
    Const SingleVitoCruzBaclaran = 15
    Const SingleVitoCruzEDSA = 15
    Const SingleVitoCruzLibertad = 15
    Const SingleVitoCruzGilPuyat = 15
    Const SingleVitoCruzQuirino = 15
    Const SingleVitoCruzPedroGil = 15
    Const SingleVitoCruzUN = 15
    Const SingleVitoCruzCentral = 15
    Const SingleVitoCruzCarriedo = 15
    Const SingleVitoCruzDoroteoJose = 20
    Const SingleVitoCruzBambang = 20
    Const SingleVitoCruzTayuman = 20
    Const SingleVitoCruzBlumentritt = 20
    Const SingleVitoCruzAbadSantos = 20
    Const SingleVitoCruzRPapa = 20
    Const SingleVitoCruz5thAvenue = 30
    Const SingleVitoCruzMonumento = 30
    Const SingleVitoCruzBalintawak = 30
    Const SingleVitoCruzRoosevelt = 30
    ' Single Journey Quirino
    Const SingleQuirinoBaclaran = 15
    Const SingleQuirinoEDSA = 15
    Const SingleQuirinoLibertad = 15
    Const SingleQuirinoGilPuyat = 15
    Const SingleQuirinoVitoCruz = 15
    Const SingleQuirinoPedroGil = 15
    Const SingleQuirinoUN = 15
    Const SingleQuirinoCentral = 15
    Const SingleQuirinoCarriedo = 15
    Const SingleQuirinoDoroteoJose = 15
    Const SingleQuirinoBambang = 20
    Const SingleQuirinoTayuman = 20
    Const SingleQuirinoBlumentritt = 20
    Const SingleQuirinoAbadSantos = 20
    Const SingleQuirinoRPapa = 20
    Const SingleQuirino5thAvenue = 20
    Const SingleQuirinoMonumento = 30
    Const SingleQuirinoBalintawak = 30
    Const SingleQuirinoRoosevelt = 30
    ' Single Journey Pedro Gil
    Const SinglePedroGilBaclaran = 20
    Const SinglePedroGilEDSA = 15
    Const SinglePedroGilLibertad = 15
    Const SinglePedroGilGilPuyat = 15
    Const SinglePedroGilVitoCruz = 15
    Const SinglePedroGilQuirino = 15
    Const SinglePedroGilUN = 15
    Const SinglePedroGilCentral = 15
    Const SinglePedroGilCarriedo = 15
    Const SinglePedroGilDoroteoJose = 15
    Const SinglePedroGilBambang = 15
    Const SinglePedroGilTayuman = 20
    Const SinglePedroGilBlumentritt = 20
    Const SinglePedroGilAbadSantos = 20
    Const SinglePedroGilRPapa = 20
    Const SinglePedroGil5thAvenue = 20
    Const SinglePedroGilMonumento = 20
    Const SinglePedroGilBalintawak = 30
    Const SinglePedroGilRoosevelt = 30
    ' Single Journey UN
    Const SingleUNBaclaran = 20
    Const SingleUNEDSA = 20
    Const SingleUNLibertad = 15
    Const SingleUNGilPuyat = 15
    Const SingleUNVitoCruz = 15
    Const SingleUNQuirino = 15
    Const SingleUNPedroGil = 15
    Const SingleUNCentral = 15
    Const SingleUNCarriedo = 15
    Const SingleUNDoroteoJose = 15
    Const SingleUNBambang = 15
    Const SingleUNTayuman = 15
    Const SingleUNBlumentritt = 20
    Const SingleUNAbadSantos = 20
    Const SingleUNRPapa = 20
    Const SingleUN5thAvenue = 20
    Const SingleUNMonumento = 20
    Const SingleUNBalintawak = 30
    Const SingleUNRoosevelt = 30
    ' Single Journey Central
    Const SingleCentralBaclaran = 20
    Const SingleCentralEDSA = 20
    Const SingleCentralLibertad = 20
    Const SingleCentralGilPuyat = 20
    Const SingleCentralVitoCruz = 15
    Const SingleCentralQuirino = 15
    Const SingleCentralPedroGil = 15
    Const SingleCentralUN = 15
    Const SingleCentralCarriedo = 15
    Const SingleCentralDoroteoJose = 15
    Const SingleCentralBambang = 15
    Const SingleCentralTayuman = 15
    Const SingleCentralBlumentritt = 15
    Const SingleCentralAbadSantos = 15
    Const SingleCentralRPapa = 20
    Const SingleCentral5thAvenue = 20
    Const SingleCentralMonumento = 20
    Const SingleCentralBalintawak = 20
    Const SingleCentralRoosevelt = 30
    ' Single Journey Carriedo
    Const SingleCarriedoBaclaran = 20
    Const SingleCarriedoEDSA = 20
    Const SingleCarriedoLibertad = 20
    Const SingleCarriedoGilPuyat = 20
    Const SingleCarriedoVitoCruz = 15
    Const SingleCarriedoQuirino = 15
    Const SingleCarriedoPedroGil = 15
    Const SingleCarriedoUN = 15
    Const SingleCarriedoCentral = 15
    Const SingleCarriedoDoroteoJose = 15
    Const SingleCarriedoBambang = 15
    Const SingleCarriedoTayuman = 15
    Const SingleCarriedoBlumentritt = 15
    Const SingleCarriedoAbadSantos = 15
    Const SingleCarriedoRPapa = 15
    Const SingleCarriedo5thAvenue = 20
    Const SingleCarriedoMonumento = 20
    Const SingleCarriedoBalintawak = 20
    Const SingleCarriedoRoosevelt = 30
    ' Single Journey Doroteo Jose
    Const SingleDoroteoJoseBaclaran = 20
    Const SingleDoroteoJoseEDSA = 20
    Const SingleDoroteoJoseLibertad = 20
    Const SingleDoroteoJoseGilPuyat = 20
    Const SingleDoroteoJoseVitoCruz = 20
    Const SingleDoroteoJoseQuirino = 15
    Const SingleDoroteoJosePedroGil = 15
    Const SingleDoroteoJoseUN = 15
    Const SingleDoroteoJoseCentral = 15
    Const SingleDoroteoJoseCarriedo = 15
    Const SingleDoroteoJoseBambang = 15
    Const SingleDoroteoJoseTayuman = 15
    Const SingleDoroteoJoseBlumentritt = 15
    Const SingleDoroteoJoseAbadSantos = 15
    Const SingleDoroteoJoseRPapa = 15
    Const SingleDoroteoJose5thAvenue = 15
    Const SingleDoroteoJoseMonumento = 20
    Const SingleDoroteoJoseBalintawak = 20
    Const SingleDoroteoJoseRoosevelt = 30
    ' Single Journey Bambang
    Const SingleBambangBaclaran = 20
    Const SingleBambangEDSA = 20
    Const SingleBambangLibertad = 20
    Const SingleBambangGilPuyat = 20
    Const SingleBambangVitoCruz = 20
    Const SingleBambangQuirino = 20
    Const SingleBambangPedroGil = 15
    Const SingleBambangUN = 15
    Const SingleBambangCentral = 15
    Const SingleBambangCarriedo = 15
    Const SingleBambangDoroteoJose = 15
    Const SingleBambangTayuman = 15
    Const SingleBambangBlumentritt = 15
    Const SingleBambangAbadSantos = 15
    Const SingleBambangRPapa = 15
    Const SingleBambang5thAvenue = 15
    Const SingleBambangMonumento = 20
    Const SingleBambangBalintawak = 20
    Const SingleBambangRoosevelt = 20
    ' Single Journey Tayuman
    Const SingleTayumanBaclaran = 30
    Const SingleTayumanEDSA = 20
    Const SingleTayumanLibertad = 20
    Const SingleTayumanGilPuyat = 20
    Const SingleTayumanVitoCruz = 20
    Const SingleTayumanQuirino = 20
    Const SingleTayumanPedroGil = 20
    Const SingleTayumanUN = 15
    Const SingleTayumanCentral = 15
    Const SingleTayumanCarriedo = 15
    Const SingleTayumanDoroteoJose = 15
    Const SingleTayumanBambang = 15
    Const SingleTayumanBlumentritt = 15
    Const SingleTayumanAbadSantos = 15
    Const SingleTayumanRPapa = 15
    Const SingleTayuman5thAvenue = 15
    Const SingleTayumanMonumento = 15
    Const SingleTayumanBalintawak = 20
    Const SingleTayumanRoosevelt = 20
    ' Single Journey Blumentritt
    Const SingleBlumentrittBaclaran = 30
    Const SingleBlumentrittEDSA = 30
    Const SingleBlumentrittLibertad = 20
    Const SingleBlumentrittGilPuyat = 20
    Const SingleBlumentrittVitoCruz = 20
    Const SingleBlumentrittQuirino = 20
    Const SingleBlumentrittPedroGil = 20
    Const SingleBlumentrittUN = 20
    Const SingleBlumentrittCentral = 15
    Const SingleBlumentrittCarriedo = 15
    Const SingleBlumentrittDoroteoJose = 15
    Const SingleBlumentrittBambang = 15
    Const SingleBlumentrittTayuman = 15
    Const SingleBlumentrittAbadSantos = 15
    Const SingleBlumentrittRPapa = 15
    Const SingleBlumentritt5thAvenue = 15
    Const SingleBlumentrittMonumento = 15
    Const SingleBlumentrittBalintawak = 20
    Const SingleBlumentrittRoosevelt = 20
    ' Single Journey Abad Santos
    Const SingleAbadSantosBaclaran = 30
    Const SingleAbadSantosEDSA = 30
    Const SingleAbadSantosLibertad = 30
    Const SingleAbadSantosGilPuyat = 20
    Const SingleAbadSantosVitoCruz = 20
    Const SingleAbadSantosQuirino = 20
    Const SingleAbadSantosPedroGil = 20
    Const SingleAbadSantosUN = 20
    Const SingleAbadSantosCentral = 15
    Const SingleAbadSantosCarriedo = 15
    Const SingleAbadSantosDoroteoJose = 15
    Const SingleAbadSantosBambang = 15
    Const SingleAbadSantosTayuman = 15
    Const SingleAbadSantosBlumentritt = 15
    Const SingleAbadSantosRPapa = 15
    Const SingleAbadSantos5thAvenue = 15
    Const SingleAbadSantosMonumento = 15
    Const SingleAbadSantosBalintawak = 20
    Const SingleAbadSantosRoosevelt = 20
    ' Single Journey R. Papa
    Const SingleRPapaBaclaran = 30
    Const SingleRPapaEDSA = 30
    Const SingleRPapaLibertad = 30
    Const SingleRPapaGilPuyat = 30
    Const SingleRPapaVitoCruz = 20
    Const SingleRPapaQuirino = 20
    Const SingleRPapaPedroGil = 20
    Const SingleRPapaUN = 20
    Const SingleRPapaCentral = 20
    Const SingleRPapaCarriedo = 15
    Const SingleRPapaDoroteoJose = 15
    Const SingleRPapaBambang = 15
    Const SingleRPapaTayuman = 15
    Const SingleRPapaBlumentritt = 15
    Const SingleRPapaAbadSantos = 15
    Const SingleRPapa5thAvenue = 15
    Const SingleRPapaMonumento = 15
    Const SingleRPapaBalintawak = 15
    Const SingleRPapaRoosevelt = 20
    ' Single Journey 5th Avenue
    Const Single5thAvenueBaclaran = 30
    Const Single5thAvenueEDSA = 30
    Const Single5thAvenueLibertad = 30
    Const Single5thAvenueGilPuyat = 30
    Const Single5thAvenueVitoCruz = 30
    Const Single5thAvenueQuirino = 20
    Const Single5thAvenuePedroGil = 20
    Const Single5thAvenueUN = 20
    Const Single5thAvenueCentral = 20
    Const Single5thAvenueCarriedo = 20
    Const Single5thAvenueDoroteoJose = 15
    Const Single5thAvenueBambang = 15
    Const Single5thAvenueTayuman = 15
    Const Single5thAvenueBlumentritt = 15
    Const Single5thAvenueAbadSantos = 15
    Const Single5thAvenueRPapa = 15
    Const Single5thAvenueMonumento = 15
    Const Single5thAvenueBalintawak = 15
    Const Single5thAvenueRoosevelt = 20
    ' Single Journey Monumento
    Const SingleMonumentoBaclaran = 30
    Const SingleMonumentoEDSA = 30
    Const SingleMonumentoLibertad = 30
    Const SingleMonumentoGilPuyat = 30
    Const SingleMonumentoVitoCruz = 30
    Const SingleMonumentoQuirino = 30
    Const SingleMonumentoPedroGil = 20
    Const SingleMonumentoUN = 20
    Const SingleMonumentoCentral = 20
    Const SingleMonumentoCarriedo = 20
    Const SingleMonumentoDoroteoJose = 20
    Const SingleMonumentoBambang = 20
    Const SingleMonumentoTayuman = 15
    Const SingleMonumentoBlumentritt = 15
    Const SingleMonumentoAbadSantos = 15
    Const SingleMonumentoRPapa = 15
    Const SingleMonumento5thAvenue = 15
    Const SingleMonumentoBalintawak = 15
    Const SingleMonumentoRoosevelt = 15
    ' Single Journey Balintawak
    Const SingleBalintawakBaclaran = 30
    Const SingleBalintawakEDSA = 30
    Const SingleBalintawakLibertad = 30
    Const SingleBalintawakGilPuyat = 30
    Const SingleBalintawakVitoCruz = 30
    Const SingleBalintawakQuirino = 30
    Const SingleBalintawakPedroGil = 30
    Const SingleBalintawakUN = 30
    Const SingleBalintawakCentral = 20
    Const SingleBalintawakCarriedo = 20
    Const SingleBalintawakDoroteoJose = 20
    Const SingleBalintawakBambang = 20
    Const SingleBalintawakTayuman = 20
    Const SingleBalintawakBlumentritt = 20
    Const SingleBalintawakAbadSantos = 20
    Const SingleBalintawakRPapa = 15
    Const SingleBalintawak5thAvenue = 15
    Const SingleBalintawakMonumento = 15
    Const SingleBalintawakRoosevelt = 15
    ' Single Journey Roosevelt
    Const SingleRooseveltBaclaran = 30
    Const SingleRooseveltEDSA = 30
    Const SingleRooseveltLibertad = 30
    Const SingleRooseveltGilPuyat = 30
    Const SingleRooseveltVitoCruz = 30
    Const SingleRooseveltQuirino = 30
    Const SingleRooseveltPedroGil = 30
    Const SingleRooseveltUN = 30
    Const SingleRooseveltCentral = 30
    Const SingleRooseveltCarriedo = 30
    Const SingleRooseveltDoroteoJose = 30
    Const SingleRooseveltBambang = 20
    Const SingleRooseveltTayuman = 20
    Const SingleRooseveltBlumentritt = 20
    Const SingleRooseveltAbadSantos = 20
    Const SingleRooseveltRPapa = 20
    Const SingleRoosevelt5thAvenue = 20
    Const SingleRooseveltMonumento = 15
    Const SingleRooseveltBalintawak = 15
    ' Stored Value Baclaran
    Const StoredBaclaranEDSA = 12
    Const StoredBaclaranLibertad = 13
    Const StoredBaclaranGilPuyat = 13
    Const StoredBaclaranVitoCruz = 14
    Const StoredBaclaranQuirino = 15
    Const StoredBaclaranPedroGil = 16
    Const StoredBaclaranUN = 17
    Const StoredBaclaranCentral = 18
    Const StoredBaclaranCarriedo = 19
    Const StoredBaclaranDoreteoJose = 19
    Const StoredBaclaranBambang = 20
    Const StoredBaclaranTayuman = 21
    Const StoredBaclaranBlumentritt = 21
    Const StoredBaclaranAbadSantos = 22
    Const StoredBaclaranRPapa = 23
    Const StoredBaclaran5thAvenue = 24
    Const StoredBaclaranMonumento = 25
    Const StoredBaclaranBalintawak = 27
    Const StoredBaclaranRoosevelt = 29
    ' Stored Value EDSA
    Const StoredEDSABaclaran = 12
    Const StoredEDSALibertad = 12
    Const StoredEDSAGilPuyat = 13
    Const StoredEDSAVitoCruz = 14
    Const StoredEDSAQuirino = 15
    Const StoredEDSAPedroGil = 15
    Const StoredEDSAUN = 16
    Const StoredEDSACentral = 17
    Const StoredEDSACarriedo = 18
    Const StoredEDSADoroteoJose = 19
    Const StoredEDSABambang = 19
    Const StoredEDSATayuman = 20
    Const StoredEDSABlumentritt = 21
    Const StoredEDSAAbadSantos = 22
    Const StoredEDSARPapa = 22
    Const StoredEDSA5thAvenue = 23
    Const StoredEDSAMonumento = 24
    Const StoredEDSABalintawak = 27
    Const StoredEDSARoosevelt = 29
    ' Stored Value Libertad
    Const StoredLibertadBaclaran = 13
    Const StoredLibertadEDSA = 12
    Const StoredLibertadGilPuyat = 12
    Const StoredLibertadVitoCruz = 13
    Const StoredLibertadQuirino = 14
    Const StoredLibertadPedroGil = 14
    Const StoredLibertadUN = 15
    Const StoredLibertadCentral = 16
    Const StoredLibertadCarriedo = 17
    Const StoredLibertadDoroteoJose = 18
    Const StoredLibertadBambang = 18
    Const StoredLibertadTayuman = 19
    Const StoredLibertadBlumentritt = 20
    Const StoredLibertadAbadSantos = 21
    Const StoredLibertadRPapa = 21
    Const StoredLibertad5thAvenue = 22
    Const StoredLibertadMonumento = 23
    Const StoredLibertadBalintawak = 26
    Const StoredLibertadRoosevelt = 28
    ' Stored Value Gil Puyat
    Const StoredGilPuyatBaclaran = 13
    Const StoredGilPuyatEDSA = 13
    Const StoredGilPuyatLibertad = 12
    Const StoredGilPuyatVitoCruz = 12
    Const StoredGilPuyatQuirino = 13
    Const StoredGilPuyatPedroGil = 14
    Const StoredGilPuyatUN = 14
    Const StoredGilPuyatCentral = 16
    Const StoredGilPuyatCarriedo = 16
    Const StoredGilPuyatDoroteoJose = 17
    Const StoredGilPuyatBambang = 18
    Const StoredGilPuyatTayuman = 18
    Const StoredGilPuyatBlumentritt = 19
    Const StoredGilPuyatAbadSantos = 20
    Const StoredGilPuyatRPapa = 21
    Const StoredGilPuyat5thAvenue = 22
    Const StoredGilPuyatMonumento = 23
    Const StoredGilPuyatBalintawak = 25
    Const StoredGilPuyatRoosevelt = 27
    ' Stored Value Vito Cruz
    Const StoredVitoCruzBaclaran = 14
    Const StoredVitoCruzEDSA = 14
    Const StoredVitoCruzLibertad = 13
    Const StoredVitoCruzGilPuyat = 12
    Const StoredVitoCruzQuirino = 12
    Const StoredVitoCruzPedroGil = 13
    Const StoredVitoCruzUN = 13
    Const StoredVitoCruzCentral = 15
    Const StoredVitoCruzCarriedo = 15
    Const StoredVitoCruzDoroteoJose = 16
    Const StoredVitoCruzBambang = 17
    Const StoredVitoCruzTayuman = 17
    Const StoredVitoCruzBlumentritt = 18
    Const StoredVitoCruzAbadSantos = 19
    Const StoredVitoCruzRPapa = 20
    Const StoredVitoCruz5thAvenue = 21
    Const StoredVitoCruzMonumento = 22
    Const StoredVitoCruzBalintawak = 24
    Const StoredVitoCruzRoosevelt = 26
    ' Stored Value Quirino
    Const StoredQuirinoBaclaran = 15
    Const StoredQuirinoEDSA = 15
    Const StoredQuirinoLibertad = 14
    Const StoredQuirinoGilPuyat = 13
    Const StoredQuirinoVitoCruz = 12
    Const StoredQuirinoPedroGil = 12
    Const StoredQuirinoUN = 13
    Const StoredQuirinoCentral = 14
    Const StoredQuirinoCarriedo = 14
    Const StoredQuirinoDoroteoJose = 15
    Const StoredQuirinoBambang = 16
    Const StoredQuirinoTayuman = 16
    Const StoredQuirinoBlumentritt = 17
    Const StoredQuirinoAbadSantos = 18
    Const StoredQuirinoRPapa = 19
    Const StoredQuirino5thAvenue = 20
    Const StoredQuirinoMonumento = 21
    Const StoredQuirinoBalintawak = 23
    Const StoredQuirinoRoosevelt = 25
    ' Stored Value Pedro Gil
    Const StoredPedroGilBaclaran = 16
    Const StoredPedroGilEDSA = 15
    Const StoredPedroGilLibertad = 14
    Const StoredPedroGilGilPuyat = 14
    Const StoredPedroGilVitoCruz = 13
    Const StoredPedroGilQuirino = 12
    Const StoredPedroGilUN = 12
    Const StoredPedroGilCentral = 13
    Const StoredPedroGilCarriedo = 14
    Const StoredPedroGilDoroteoJose = 14
    Const StoredPedroGilBambang = 15
    Const StoredPedroGilTayuman = 16
    Const StoredPedroGilBlumentritt = 16
    Const StoredPedroGilAbadSantos = 17
    Const StoredPedroGilRPapa = 18
    Const StoredPedroGil5thAvenue = 19
    Const StoredPedroGilMonumento = 20
    Const StoredPedroGilBalintawak = 22
    Const StoredPedroGilRoosevelt = 24
    ' Stored Value UN
    Const StoredUNBaclaran = 17
    Const StoredUNEDSA = 16
    Const StoredUNLibertad = 15
    Const StoredUNGilPuyat = 14
    Const StoredUNVitoCruz = 13
    Const StoredUNQuirino = 13
    Const StoredUNPedroGil = 12
    Const StoredUNCentral = 12
    Const StoredUNCarriedo = 13
    Const StoredUNDoroteoJose = 14
    Const StoredUNBambang = 14
    Const StoredUNTayuman = 15
    Const StoredUNBlumentritt = 16
    Const StoredUNAbadSantos = 17
    Const StoredUNRPapa = 17
    Const StoredUN5thAvenue = 18
    Const StoredUNMonumento = 19
    Const StoredUNBalintawak = 22
    Const StoredUNRoosevelt = 23
    ' Stored Value Central
    Const StoredCentralBaclaran = 18
    Const StoredCentralEDSA = 17
    Const StoredCentralLibertad = 16
    Const StoredCentralGilPuyat = 16
    Const StoredCentralVitoCruz = 15
    Const StoredCentralQuirino = 14
    Const StoredCentralPedroGil = 13
    Const StoredCentralUN = 12
    Const StoredCentralCarriedo = 12
    Const StoredCentralDoroteoJose = 12
    Const StoredCentralBambang = 13
    Const StoredCentralTayuman = 14
    Const StoredCentralBlumentritt = 14
    Const StoredCentralAbadSantos = 15
    Const StoredCentralRPapa = 16
    Const StoredCentral5thAvenue = 17
    Const StoredCentralMonumento = 18
    Const StoredCentralBalintawak = 20
    Const StoredCentralRoosevelt = 22
    ' Stored Value Carriedo
    Const StoredCarriedoBaclaran = 19
    Const StoredCarriedoEDSA = 18
    Const StoredCarriedoLibertad = 17
    Const StoredCarriedoGilPuyat = 16
    Const StoredCarriedoVitoCruz = 15
    Const StoredCarriedoQuirino = 14
    Const StoredCarriedoPedroGil = 14
    Const StoredCarriedoUN = 13
    Const StoredCarriedoCentral = 12
    Const StoredCarriedoDoroteoJose = 12
    Const StoredCarriedoBambang = 12
    Const StoredCarriedoTayuman = 13
    Const StoredCarriedoBlumentritt = 14
    Const StoredCarriedoAbadSantos = 15
    Const StoredCarriedoRPapa = 15
    Const StoredCarriedo5thAvenue = 16
    Const StoredCarriedoMonumento = 17
    Const StoredCarriedoBalintawak = 20
    Const StoredCarriedoRoosevelt = 22
    ' Stored Value Doroteo Jose
    Const StoredDoroteoJoseBaclaran = 19
    Const StoredDoroteoJoseEDSA = 19
    Const StoredDoroteoJoseLibertad = 18
    Const StoredDoroteoJoseGilPuyat = 17
    Const StoredDoroteoJoseVitoCruz = 16
    Const StoredDoroteoJoseQuirino = 15
    Const StoredDoroteoJosePedroGil = 14
    Const StoredDoroteoJoseUN = 14
    Const StoredDoroteoJoseCentral = 12
    Const StoredDoroteoJoseCarriedo = 12
    Const StoredDoroteoJoseBambang = 12
    Const StoredDoroteoJoseTayuman = 12
    Const StoredDoroteoJoseBlumentritt = 13
    Const StoredDoroteoJoseAbadSantos = 14
    Const StoredDoroteoJoseRPapa = 15
    Const StoredDoroteoJose5thAvenue = 15
    Const StoredDoroteoJoseMonumento = 17
    Const StoredDoroteoJoseBalintawak = 19
    Const StoredDoroteoJoseRoosevelt = 21
    ' Stored Value Bambang
    Const StoredBambangBaclaran = 20
    Const StoredBambangEDSA = 19
    Const StoredBambangLibertad = 18
    Const StoredBambangGilPuyat = 18
    Const StoredBambangVitoCruz = 17
    Const StoredBambangQuirino = 16
    Const StoredBambangPedroGil = 15
    Const StoredBambangUN = 14
    Const StoredBambangCentral = 13
    Const StoredBambangCarriedo = 12
    Const StoredBambangDoroteoJose = 12
    Const StoredBambangTayuman = 12
    Const StoredBambangBlumentritt = 12
    Const StoredBambangAbadSantos = 13
    Const StoredBambangRPapa = 14
    Const StoredBambang5thAvenue = 15
    Const StoredBambangMonumento = 16
    Const StoredBambangBalintawak = 18
    Const StoredBambangRoosevelt = 20
    ' Stored Value Tayuman
    Const StoredTayumanBaclaran = 21
    Const StoredTayumanEDSA = 20
    Const StoredTayumanLibertad = 19
    Const StoredTayumanGilPuyat = 18
    Const StoredTayumanVitoCruz = 17
    Const StoredTayumanQuirino = 16
    Const StoredTayumanPedroGil = 16
    Const StoredTayumanUN = 15
    Const StoredTayumanCentral = 14
    Const StoredTayumanCarriedo = 13
    Const StoredTayumanDoroteoJose = 12
    Const StoredTayumanBambang = 12
    Const StoredTayumanBlumentritt = 12
    Const StoredTayumanAbadSantos = 13
    Const StoredTayumanRPapa = 13
    Const StoredTayuman5thAvenue = 14
    Const StoredTayumanMonumento = 15
    Const StoredTayumanBalintawak = 18
    Const StoredTayumanRoosevelt = 20
    ' Stored Value Blumentritt
    Const StoredBlumentrittBaclaran = 21
    Const StoredBlumentrittEDSA = 21
    Const StoredBlumentrittLibertad = 20
    Const StoredBlumentrittGilPuyat = 19
    Const StoredBlumentrittVitoCruz = 18
    Const StoredBlumentrittQuirino = 17
    Const StoredBlumentrittPedroGil = 16
    Const StoredBlumentrittUN = 16
    Const StoredBlumentrittCentral = 14
    Const StoredBlumentrittCarriedo = 14
    Const StoredBlumentrittDoroteoJose = 13
    Const StoredBlumentrittBambang = 12
    Const StoredBlumentrittTayuman = 12
    Const StoredBlumentrittAbadSantos = 12
    Const StoredBlumentrittRPapa = 13
    Const StoredBlumentritt5thAvenue = 14
    Const StoredBlumentrittMonumento = 15
    Const StoredBlumentrittBalintawak = 17
    Const StoredBlumentrittRoosevelt = 19
    ' Stored Value Abad Santos
    Const StoredAbadSantosBaclaran = 22
    Const StoredAbadSantosEDSA = 22
    Const StoredAbadSantosLibertad = 21
    Const StoredAbadSantosGilPuyat = 20
    Const StoredAbadSantosVitoCruz = 19
    Const StoredAbadSantosQuirino = 18
    Const StoredAbadSantosPedroGil = 17
    Const StoredAbadSantosUN = 17
    Const StoredAbadSantosCentral = 15
    Const StoredAbadSantosCarriedo = 15
    Const StoredAbadSantosDoroteoJose = 14
    Const StoredAbadSantosBambang = 13
    Const StoredAbadSantosTayuman = 13
    Const StoredAbadSantosBlumentritt = 12
    Const StoredAbadSantosRPapa = 12
    Const StoredAbadSantos5thAvenue = 13
    Const StoredAbadSantosMonumento = 14
    Const StoredAbadSantosBalintawak = 16
    Const StoredAbadSantosRoosevelt = 18
    ' Stored Value R. Papa
    Const StoredRPapaBaclaran = 23
    Const StoredRPapaEDSA = 22
    Const StoredRPapaLibertad = 21
    Const StoredRPapaGilPuyat = 21
    Const StoredRPapaVitoCruz = 20
    Const StoredRPapaQuirino = 19
    Const StoredRPapaPedroGil = 18
    Const StoredRPapaUN = 17
    Const StoredRPapaCentral = 16
    Const StoredRPapaCarriedo = 15
    Const StoredRPapaDoroteoJose = 15
    Const StoredRPapaBambang = 14
    Const StoredRPapaTayuman = 13
    Const StoredRPapaBlumentritt = 13
    Const StoredRPapaAbadSantos = 12
    Const StoredRPapa5thAvenue = 12
    Const StoredRPapaMonumento = 13
    Const StoredRPapaBalintawak = 15
    Const StoredRPapaRoosevelt = 17
    ' Stored Value 5th Avenue
    Const Stored5thAvenueBaclaran = 24
    Const Storede5thAvenueEDSA = 23
    Const Stored5thAvenueLibertad = 22
    Const Stored5thAvenueGilPuyat = 22
    Const Stored5thAvenueVitoCruz = 21
    Const Stored5thAvenueQuirino = 20
    Const Stored5thAvenuePedroGil = 19
    Const Stored5thAvenueUN = 18
    Const Stored5thAvenueCentral = 17
    Const Stored5thAvenueCarriedo = 16
    Const Stored5thAvenueDoroteoJose = 15
    Const Stored5thAvenueBambang = 15
    Const Stored5thAvenueTayuman = 14
    Const Stored5thAvenueBlumentritt = 14
    Const Stored5thAvenueAbadSantos = 13
    Const Stored5thAvenueRPapa = 12
    Const Stored5thAvenueMonumento = 12
    Const Stored5thAvenueBalintawak = 15
    Const Stored5thAvenueRoosevelt = 16
    ' Stored Value Monumento
    Const StoredMonumentoBaclaran = 25
    Const StoredMonumentoEDSA = 24
    Const StoredMonumentoLibertad = 23
    Const StoredMonumentoGilPuyat = 23
    Const StoredMonumentoVitoCruz = 22
    Const StoredMonumentoQuirino = 21
    Const StoredMonumentoPedroGil = 20
    Const StoredMonumentoUN = 19
    Const StoredMonumentoCentral = 18
    Const StoredMonumentoCarriedo = 17
    Const StoredMonumentoDoroteoJose = 17
    Const StoredMonumentoBambang = 16
    Const StoredMonumentoTayuman = 15
    Const StoredMonumentoBlumentritt = 15
    Const StoredMonumentoAbadSantos = 14
    Const StoredMonumentoRPapa = 13
    Const StoredMonumento5thAvenue = 12
    Const StoredMonumentoBalintawak = 13
    Const StoredMonumentoRoosevelt = 15
    ' Stored Value Balintawak
    Const StoredBalintawakBaclaran = 27
    Const StoredBalintawakEDSA = 27
    Const StoredBalintawakLibertad = 26
    Const StoredBalintawakGilPuyat = 25
    Const StoredBalintawakVitoCruz = 24
    Const StoredBalintawakQuirino = 23
    Const StoredBalintawakPedroGil = 22
    Const StoredBalintawakUN = 22
    Const StoredBalintawakCentral = 20
    Const StoredBalintawakCarriedo = 20
    Const StoredBalintawakDoroteoJose = 19
    Const StoredBalintawakBambang = 18
    Const StoredBalintawakTayuman = 18
    Const StoredBalintawakBlumentritt = 17
    Const StoredBalintawakAbadSantos = 16
    Const StoredBalintawakRPapa = 15
    Const StoredBalintawak5thAvenue = 15
    Const StoredBalintawakMonumento = 13
    Const StoredBalintawakRoosevelt = 13
    ' Stored Value Roosevelt
    Const StoredRooseveltBaclaran = 29
    Const StoredRooseveltEDSA = 29
    Const StoredRooseveltLibertad = 28
    Const StoredRooseveltGilPuyat = 27
    Const StoredRooseveltVitoCruz = 26
    Const StoredRooseveltQuirino = 25
    Const StoredRooseveltPedroGil = 24
    Const StoredRooseveltUN = 23
    Const StoredRooseveltCentral = 22
    Const StoredRooseveltCarriedo = 22
    Const StoredRooseveltDoroteoJose = 21
    Const StoredRooseveltBambang = 20
    Const StoredRooseveltTayuman = 20
    Const StoredRooseveltBlumentritt = 19
    Const StoredRooseveltAbadSantos = 18
    Const StoredRooseveltRPapa = 17
    Const StoredRoosevelt5thAvenue = 16
    Const StoredRooseveltMonumento = 15
    Const StoredRooseveltBalintawak = 13
    Const Discount = 0.2
    Dim ForSeniors As Double

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "0"
        Else
            lblDisplay.Text = "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "1"
        Else
            lblDisplay.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "2"
        Else
            lblDisplay.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "3"
        Else
            lblDisplay.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "4"
        Else
            lblDisplay.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "5"
        Else
            lblDisplay.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "6"
        Else
            lblDisplay.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "7"
        Else
            lblDisplay.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "8"
        Else
            lblDisplay.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        If lblDisplay.Text <> "0" Then
            lblDisplay.Text += "9"
        Else
            lblDisplay.Text = "9"
        End If
    End Sub

    Private Sub btnPlus_Click(sender As System.Object, e As System.EventArgs) Handles btnPlus.Click
        num1 = lblDisplay.Text
        lblDisplay.Text = "0"
        operanselected = True
        operan = 1
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.EventArgs) Handles btnMinus.Click
        num1 = lblDisplay.Text
        lblDisplay.Text = "0"
        operanselected = True
        operan = 2
    End Sub

    Private Sub btnTimes_Click(sender As System.Object, e As System.EventArgs) Handles btnTimes.Click
        num1 = lblDisplay.Text
        lblDisplay.Text = "0"
        operanselected = True
        operan = 3
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        num1 = lblDisplay.Text
        lblDisplay.Text = "0"
        operanselected = True
        operan = 5
    End Sub

    Private Sub btnMod_Click(sender As System.Object, e As System.EventArgs) Handles btnMod.Click
        num1 = lblDisplay.Text
        lblDisplay.Text = "0"
        operanselected = True
        operan = 4
    End Sub

    Private Sub btnDecimal_Click(sender As System.Object, e As System.EventArgs) Handles btnDecimal.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub btnC_Click(sender As System.Object, e As System.EventArgs) Handles btnC.Click
        lblDisplay.Text = ""
        lblDisplay.Text = "0"
    End Sub

    Private Sub btnEquals_Click(sender As System.Object, e As System.EventArgs) Handles btnEquals.Click
        If operanselected = True Then
            num2 = lblDisplay.Text
            If operan = 1 Then
                lblDisplay.Text = num1 + num2
            ElseIf operan = 2 Then
                lblDisplay.Text = num1 - num2
            ElseIf operan = 3 Then
                lblDisplay.Text = num1 * num2
            ElseIf operan = 4 Then
                lblDisplay.Text = num1 Mod num2
            Else
                If num2 = "0" Then
                    lblDisplay.Text = "Error!"
                Else
                    lblDisplay.Text = num1 / num2
                End If
            End If
            operanselected = False
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Origin
        cmbOrigin.Items.Add("Baclaran Terminal")
        cmbOrigin.Items.Add("EDSA Terminal")
        cmbOrigin.Items.Add("Libertad Terminal")
        cmbOrigin.Items.Add("Gil Puyat Terminal")
        cmbOrigin.Items.Add("Vito Cruz Terminal")
        cmbOrigin.Items.Add("Quirino Terminal")
        cmbOrigin.Items.Add("Pedro Gil Terminal")
        cmbOrigin.Items.Add("U.N. Avenue Terminal")
        cmbOrigin.Items.Add("Central Terminal")
        cmbOrigin.Items.Add("Carriedo Terminal")
        cmbOrigin.Items.Add("Doroteo Jose Terminal")
        cmbOrigin.Items.Add("Bambang Terminal")
        cmbOrigin.Items.Add("Tayuman Terminal")
        cmbOrigin.Items.Add("Blumentritt Terminal")
        cmbOrigin.Items.Add("Abad Santos Terminal")
        cmbOrigin.Items.Add("R. Papa Terminal")
        cmbOrigin.Items.Add("5th Avenue Terminal")
        cmbOrigin.Items.Add("Monumento Terminal")
        cmbOrigin.Items.Add("Balintawak Terminal")
        cmbOrigin.Items.Add("Roosevelt Terminal")
        ' Destination
        cmbDestination.Items.Add("Baclaran Terminal")
        cmbDestination.Items.Add("EDSA Terminal")
        cmbDestination.Items.Add("Libertad Terminal")
        cmbDestination.Items.Add("Gil Puyat Terminal")
        cmbDestination.Items.Add("Vito Cruz Terminal")
        cmbDestination.Items.Add("Quirino Terminal")
        cmbDestination.Items.Add("Pedro Gil Terminal")
        cmbDestination.Items.Add("U.N. Avenue Terminal")
        cmbDestination.Items.Add("Central Terminal")
        cmbDestination.Items.Add("Carriedo Terminal")
        cmbDestination.Items.Add("Doroteo Jose Terminal")
        cmbDestination.Items.Add("Bambang Terminal")
        cmbDestination.Items.Add("Tayuman Terminal")
        cmbDestination.Items.Add("Blumentritt Terminal")
        cmbDestination.Items.Add("Abad Santos Terminal")
        cmbDestination.Items.Add("R. Papa Terminal")
        cmbDestination.Items.Add("5th Avenue Terminal")
        cmbDestination.Items.Add("Monumento Terminal")
        cmbDestination.Items.Add("Balintawak Terminal")
        cmbDestination.Items.Add("Roosevelt Terminal")

        btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnPlus.Enabled = False
        btnMinus.Enabled = False
        btnTimes.Enabled = False
        btnDivide.Enabled = False
        btnMod.Enabled = False
        btnEquals.Enabled = False
        btnDecimal.Enabled = False
        btnC.Enabled = False
        lblDisplay.Enabled = False
    End Sub

    Private Sub btnTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnTotal.Click
        If cmbOrigin.Text = "Baclaran Terminal" And cmbDestination.Text = "Monumento Terminal" And rbSingle.Checked And rbOrdinaryYes.Checked Then
            lblSubTotal.Text = FormatCurrency(SingleBaclaranMonumento)
            lblDiscount.Text = FormatCurrency(ForSeniors - ForSeniors)
            lblTotal.Text = lblSubTotal.Text
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = cmbOrigin.Text
            lblTo.Text = cmbDestination.Text
            lblTicketType.Text = rbSingle.Text
            lblOrdinary.Text = rbOrdinaryYes.Text
            lblSenior.Text = ""
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today
            lblTime.Text = TimeOfDay
        ElseIf cmbOrigin.Text = "Baclaran Terminal" And cmbDestination.Text = "Monumento Terminal" And rbSingle.Checked And rbSeniorYes.Checked Then
            lblSubTotal.Text = FormatCurrency(SingleBaclaranMonumento)
            ForSeniors = (SingleBaclaranMonumento * Discount)
            lblDiscount.Text = FormatCurrency(ForSeniors)
            lblTotal.Text = FormatCurrency(SingleBaclaranMonumento - ForSeniors)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = cmbOrigin.Text
            lblTo.Text = cmbDestination.Text
            lblTicketType.Text = rbSingle.Text
            lblSenior.Text = rbSeniorYes.Text
            lblOrdinary.Text = ""
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today
            lblTime.Text = TimeOfDay
        ElseIf cmbOrigin.Text = "Baclaran Terminal" And cmbDestination.Text = "Monumento Terminal" And rbStored.Checked And rbOrdinaryYes.Checked Then
            lblSubTotal.Text = FormatCurrency(StoredBaclaranMonumento)
            lblDiscount.Text = FormatCurrency(ForSeniors - ForSeniors)
            lblTotal.Text = lblSubTotal.Text
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = cmbOrigin.Text
            lblTo.Text = cmbDestination.Text
            lblTicketType.Text = rbStored.Text
            lblOrdinary.Text = rbOrdinaryYes.Text
            lblSenior.Text = ""
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today
            lblTime.Text = TimeOfDay
        ElseIf cmbOrigin.Text = "Baclaran Terminal" And cmbDestination.Text = "Monumento Terminal" And rbStored.Checked And rbSeniorYes.Checked Then
            lblSubTotal.Text = FormatCurrency(StoredBaclaranMonumento)
            ForSeniors = (StoredBaclaranMonumento * Discount)
            lblDiscount.Text = FormatCurrency(ForSeniors)
            lblTotal.Text = FormatCurrency(StoredBaclaranMonumento - ForSeniors)
            lblPrice.Text = lblTotal.Text
            lblFrom.Text = cmbOrigin.Text
            lblTo.Text = cmbDestination.Text
            lblTicketType.Text = rbStored.Text
            lblSenior.Text = rbSeniorYes.Text
            lblOrdinary.Text = ""
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))
            lblDate.Text = Today
            lblTime.Text = TimeOfDay
        End If
    End Sub

    Private Sub chbxOther_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbxOther.CheckedChanged
        If chbxOther.Checked = True Then
            btn0.Enabled = True
            btn1.Enabled = True
            btn2.Enabled = True
            btn3.Enabled = True
            btn4.Enabled = True
            btn5.Enabled = True
            btn6.Enabled = True
            btn7.Enabled = True
            btn8.Enabled = True
            btn9.Enabled = True
            btnPlus.Enabled = True
            btnMinus.Enabled = True
            btnTimes.Enabled = True
            btnDivide.Enabled = True
            btnMod.Enabled = True
            btnEquals.Enabled = True
            btnDecimal.Enabled = True
            btnC.Enabled = True
            lblDisplay.Enabled = True
        ElseIf chbxOther.Checked = False Then
            btn0.Enabled = False
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            btnPlus.Enabled = False
            btnMinus.Enabled = False
            btnTimes.Enabled = False
            btnDivide.Enabled = False
            btnMod.Enabled = False
            btnEquals.Enabled = False
            btnDecimal.Enabled = False
            btnC.Enabled = False
            lblDisplay.Enabled = False
        End If
        
    End Sub

    Private Sub rbUseCalcu_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbUseCalcu.CheckedChanged
        If rbUseCalcu.Checked = True Then
            num1 = lblDisplay.Text
            lblDiscount.Text = FormatCurrency(ForSeniors * num1)
            lblSubTotal.Text = FormatCurrency(num1 * lblSubTotal.Text)
            lblTotal.Text = FormatCurrency(lblTotal.Text * lblDisplay.Text)
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Application.Restart()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        rbSingle.Checked = False
        rbStored.Checked = False
        rbOrdinaryYes.Checked = False
        rbSeniorYes.Checked = False
        cmbOrigin.ResetText()
        cmbDestination.ResetText()
        rbUseCalcu.Checked = False
        chbxOther.Checked = False
        lblSubTotal.Text = ""
        lblDiscount.Text = ""
        lblTotal.Text = ""
        lblTicketType.Text = ""
        lblOrdinary.Text = ""
        lblSenior.Text = ""
        lblFrom.Text = ""
        lblTo.Text = ""
        lblPrice.Text = ""
        lblRefNo.Text = ""
        lblDate.Text = ""
        lblTime.Text = ""
    End Sub
End Class

function createPlacedItemHTML(item) {
	// TODO - display recieved info: name, image...

	const itemName = document.createElement("div");
	itemName.classList.add("item-name");
	itemName.textContent = item.name;

	const itemAge = document.createElement("div");
	itemAge.classList.add("item-age");

	const bCollect = document.createElement("button");
	bCollect.textContent = "Collect";
	bCollect.classList.add("b-collect");

	document
		.querySelector(`[data-land-x="${item.landX}"][data-land-y="${item.landY}"]`)
		.querySelector(`[data-tile-x="${item.tileX}"][data-tile-y="${item.tileY}"]`)
		.append(itemName, itemAge, bCollect);
}

function selectTileByCoordinates(coordinates) {
	return document
		.querySelector(`[data-land-x="${coordinates.landX}"][data-land-y="${coordinates.landY}"]`)
		.querySelector(`[data-tile-x="${coordinates.tileX}"][data-tile-y="${coordinates.tileY}"]`)
}
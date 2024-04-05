function createPlacedItemHTML(item, landHub) {
	// TODO - display recieved info: name, image...
	console.log(item);
	const itemName = document.createElement("div");
	itemName.classList.add("item-name");
	itemName.textContent = item.name;

	const itemAge = document.createElement("div");
	itemAge.classList.add("item-age");

	const bCollect = document.createElement("button");
	bCollect.textContent = "Collect";
	bCollect.classList.add("b-collect");

	bCollect.addEventListener("click", (ev) => {
		// TODO - parentNode depends on element clicked, if text clicked -> error

		const { landX, landY } = ev.target.parentNode.parentNode.parentNode.dataset;
		const { tileX, tileY } = ev.target.parentNode.parentNode.dataset;

		landHub.invoke("GatherPlant",
			parseInt(landX, 10), parseInt(landY, 10),
			parseInt(tileX, 10), parseInt(tileY, 10));
	});

	const wrap = document.createElement("div");
	wrap.append(itemName, itemAge, bCollect);

	document
		.querySelector(`[data-land-x="${item.landX}"][data-land-y="${item.landY}"]`)
		.querySelector(`[data-tile-x="${item.tileX}"][data-tile-y="${item.tileY}"]`)
		.appendChild(wrap);
}

function selectTileByCoordinates(coordinates) {
	return document
		.querySelector(`[data-land-x="${coordinates.landX}"][data-land-y="${coordinates.landY}"]`)
		.querySelector(`[data-tile-x="${coordinates.tileX}"][data-tile-y="${coordinates.tileY}"]`)
}
var assets = new Map();

export function getMessage() {
    console.log("getMessage");

    return 'Olá do Blazor!';
}

export function loadAsset(key, asset) {
    console.log(`asset {key} loaded.`);
    assets.set(key, asset);
}

export function logAssetError(key, error) {
    console.log(`asset {key} error: {error}.`);
    return error;
}

export function loadSound(key, src) {
    return new Promise((resolve, reject) => {
        console.log(`asset sound {key} load {src}`);

        var audio = new Audio();
        audio.onload = () => { loadAsset(key, audio); resolve(null); }
        audio.onerror = () => reject(logAssetError(audio.error))
        audio.src = src;
    });
}
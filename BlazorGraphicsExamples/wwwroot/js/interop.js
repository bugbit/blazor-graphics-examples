var assets = new Map();

export function getMessage() {
    console.log("getMessage");

    return 'Olá do Blazor!';
}

export function loadAsset(key, asset) {
    console.log(`asset {key} loaded.`);
    assets.set(key, asset);

    return key;
}

export function logAssetError(key, error) {
    console.log(`asset {key} error: {error}.`);
    return error;
}

export function loadSound(key, src) {
    var audio = new Audio(src);

    return audio.load().then(() => { loadAsset(key, audio); return null; }).catch(() => logAssetError(audio.error));
}
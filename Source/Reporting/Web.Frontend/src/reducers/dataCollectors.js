const baseState = {
    dataCollectors: []
};

function dataCollectors() {
    return (state = baseState, action) => {
        switch (action.type) {
            case "GET_DATACOLLECTORS": {
                return { ...state, dataCollectors: action.payload };
            }
            default:
                return state;
        }
    };
}

export default dataCollectors;

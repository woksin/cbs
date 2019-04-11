const baseState = {
    caseReports: []
};

function caseReports() {
    return (state = baseState, action) => {
        switch (action.type) {
            case "GET_CASEREPORTS": {
                return { ...state, caseReports: action.payload };
            }
            default:
                return state;
        }
    };
}

export default caseReports;

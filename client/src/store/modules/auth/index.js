import mutations from "./mutations.js";
import actions from "./actions.js";
import getters from "./getters.js";

export default {
  state() {
    return {
      displayName: null,
      token: null,
      isAuthenticated: false,
      didAutoLogout: false,
    };
  },
  mutations,
  actions,
  getters,
};

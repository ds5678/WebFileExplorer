

const app = Vue.createApp({
	data() {
		return {
			validatingUrl: false,
			baseUrl: window.location.host,
			version: null
		}
	},
	methods: {
		async validateBaseUrl() {
			this.validatingUrl = true;
			this.version = await this.fetchVersion();
			this.validatingUrl = false;
		},
		resetValidation() {
			this.version = null;
		},
		async fetchVersion() {
			try {
				const response = await fetch(this.versionUrl);

				if (!response.ok) {
					return null;
				}
				return await response.json();
			} catch {
				return null;
			}
		}
	},
	computed: {
		versionUrl() {
			return this.baseUrl + "/version";
		},
		baseUrlIsValid() {
			return this.version != null;
		}
	}
});